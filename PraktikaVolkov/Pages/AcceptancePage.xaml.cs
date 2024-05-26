using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using Microsoft.Office.Interop.Excel;
using PraktikaVolkov.AppData;
using PraktikaVolkov.Pages;
using Button = System.Windows.Controls.Button;
using Excel = Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;

namespace PraktikaVolkov.Pages
{
    /// <summary>
    /// Логика взаимодействия для AcceptancePage.xaml
    /// </summary>
    public partial class AcceptancePage : Page
    {
        public AcceptancePage()
        {
            InitializeComponent();
            AcceptanceBD.ItemsSource = Connect.context.Acceptence.ToList();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddAcceptancePage(null));
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delAcceptances = AcceptanceBD.SelectedItems.Cast<Acceptence>().ToList();
            foreach (var delAcceptance in delAcceptances)
                if (Connect.context.Employee.Any(x => x.DateAcceptence == delAcceptance.DateAcceptance))
                {
                    MessageBox.Show("Данные используются в таблице Принятие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {delAcceptances.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Acceptence.RemoveRange(delAcceptances);
            MessageBox.Show("Запись удалена", "Удаление", MessageBoxButton.OK, MessageBoxImage.Information);
            try
            {
                Connect.context.SaveChanges();
                AcceptanceBD.ItemsSource = Connect.context.Acceptence.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing); app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Принятые на работу";
            sheet.Cells[1, 1] = "Id принятия"; sheet.Cells[1, 2] = "Дата принятия"; sheet.Cells[1, 3] = "ФИО"; sheet.Cells[1, 4] = "Должность";
            sheet.Cells[1, 5] = "Подразделение"; sheet.Cells[1, 6] = "Оклад";
            var currentRow = 2;
            var acceptence = Connect.context.Acceptence.ToList();
            foreach (var item in acceptence)
            {
                sheet.Cells[currentRow, 1] = item.IdAcceptance;
                sheet.Cells[currentRow, 2] = item.DateAcceptance;
                sheet.Cells[currentRow, 3] = item.Employee.FIO;
                sheet.Cells[currentRow, 4] = item.Post.NamePost;
                sheet.Cells[currentRow, 5] = item.Department.NameDepartment;
                sheet.Cells[currentRow, 6] = item.Employee.Salary;
                currentRow++;
                Excel.Range range2 = sheet.get_Range("A1", "F1048576"); range2.Cells.Font.Name = "TimesNewRoman"; range2.Cells.Font.Size = 14;
                range2.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                sheet.Columns.ColumnWidth = 40;
                Excel.Range range3 = sheet.get_Range("A1", "F1"); range3.Cells.Font.Name = "TimesNewRoman"; range3.Cells.Font.Size = 14; range3.Cells.Font.Bold = true;
                range3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddAcceptancePage((sender as Button).DataContext as Acceptence));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AcceptanceBD.ItemsSource = Connect.context.Acceptence.ToList();
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            AcceptanceBD.ItemsSource = Connect.context.Acceptence.ToList().Select(x => new
            {
                IdAcceptance = x.IdAcceptance,
                DateAcceptance = x.DateAcceptance,
                IdEmployee = x.Employee.FIO,
                IdPost = x.Post.NamePost,
                IdDepartment = x.Department.NameDepartment
            });
            MessageBox.Show("Фильтрация выполнена", "Фильтрация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
