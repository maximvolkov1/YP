using PraktikaVolkov.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Button = System.Windows.Controls.Button;
using Excel = Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;
namespace PraktikaVolkov.Pages
{
    /// <summary>
    /// Логика взаимодействия для DismissalPage.xaml
    /// </summary>
    public partial class DismissalPage : Page
    {
        public DismissalPage()
        {
            InitializeComponent();
            DismissalBD.ItemsSource = Connect.context.Dismissal.ToList();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddDismissalPage(null));
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delDismissals = DismissalBD.SelectedItems.Cast<Dismissal>().ToList();
            foreach (var delDismissal in delDismissals)
                if (Connect.context.Employee.Any(x => x.DateDismissal == delDismissal.DateDismissal))
                {
                    MessageBox.Show("Данные используются в таблице Увольнение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {delDismissals.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Dismissal.RemoveRange(delDismissals);
            MessageBox.Show("Запись удалена", "Удаление", MessageBoxButton.OK, MessageBoxImage.Information);
            try
            {
                Connect.context.SaveChanges();
                DismissalBD.ItemsSource = Connect.context.Dismissal.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddDismissalPage((sender as Button).DataContext as Dismissal));
        }

        private void report_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing); app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Уволеные с работы";
            sheet.Cells[1, 1] = "Номер увольнения"; sheet.Cells[1, 2] = "Дата увольнения"; sheet.Cells[1, 3] = "ФИО"; sheet.Cells[1, 4] = "Должность";
            sheet.Cells[1, 5] = "Подразделение"; sheet.Cells[1, 6] = "Причина увольнения"; sheet.Cells[1, 7] = "Оклад";
            var currentRow = 2;
            var acceptence = Connect.context.Dismissal.ToList();
            foreach (var item in acceptence)
            {
                sheet.Cells[currentRow, 1] = item.IdDismissal;
                sheet.Cells[currentRow, 2] = item.DateDismissal;
                sheet.Cells[currentRow, 3] = item.Employee.FIO;
                sheet.Cells[currentRow, 4] = item.Post.NamePost;
                sheet.Cells[currentRow, 5] = item.Department.NameDepartment;
                sheet.Cells[currentRow, 6] = item.ReasonForDismissal;
                sheet.Cells[currentRow, 7] = item.Employee.Salary;
                currentRow++;
                Excel.Range range2 = sheet.get_Range("A1", "G1048576"); range2.Cells.Font.Name = "TimesNewRoman"; range2.Cells.Font.Size = 14;
                range2.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                sheet.Columns.ColumnWidth = 40;
                Excel.Range range3 = sheet.get_Range("A1", "G1"); range3.Cells.Font.Name = "TimesNewRoman"; range3.Cells.Font.Size = 14; range3.Cells.Font.Bold = true;
                range3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DismissalBD.ItemsSource = Connect.context.Dismissal.ToList();
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            DismissalBD.ItemsSource = Connect.context.Dismissal.ToList().Select(x => new
            {
                IdDismissal = x.IdDismissal,
                DateDismissal = x.DateDismissal,
                IdEmployee = x.Employee.FIO,
                IdPost = x.Post.NamePost,
                IdDepartment = x.Department.NameDepartment,
                ReasonForDismissal = x.ReasonForDismissal
            });
            MessageBox.Show("Фильтрация выполнена", "Фильтрация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
