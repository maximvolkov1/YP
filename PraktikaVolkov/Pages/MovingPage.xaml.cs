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
    /// Логика взаимодействия для MovingPage.xaml
    /// </summary>
    public partial class MovingPage : Page
    {
        public MovingPage()
        {
            InitializeComponent();
            MovingBD.ItemsSource = Connect.context.Moving.ToList();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddMovingPage(null));
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delMovings = MovingBD.SelectedItems.Cast<Moving>().ToList();
            foreach (var delMoving in delMovings)
                if (Connect.context.Employee.Any(x => x.DateMoving == delMoving.DateMoving))
                {
                    MessageBox.Show("Данные используются в таблице Увольнение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {delMovings.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Moving.RemoveRange(delMovings);
                MessageBox.Show("Запись удалена", "Удаление", MessageBoxButton.OK, MessageBoxImage.Information);
            try
            {
                Connect.context.SaveChanges();
                MovingBD.ItemsSource = Connect.context.Moving.ToList();
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
            Nav.MainFrame.Navigate(new AddMovingPage((sender as Button).DataContext as Moving));
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
            sheet.Name = "Перемещение по службе";
            sheet.Cells[1, 1] = "Номер перемещения"; sheet.Cells[1, 2] = "Дата перемещения"; sheet.Cells[1, 3] = "ФИО"; sheet.Cells[1, 4] = "Должность";
            sheet.Cells[1, 5] = "Из подразделения"; sheet.Cells[1, 6] = "В подразделение"; sheet.Cells[1, 7] = "Оклад";
            var currentRow = 2;
            var acceptence = Connect.context.Moving.ToList();
            foreach (var item in acceptence)
            {
                sheet.Cells[currentRow, 1] = item.IdMoving;
                sheet.Cells[currentRow, 2] = item.DateMoving;
                sheet.Cells[currentRow, 3] = item.Employee.FIO;
                sheet.Cells[currentRow, 4] = item.IdPost;
                sheet.Cells[currentRow, 5] = item.FromDepartment;
                sheet.Cells[currentRow, 6] = item.InDepartment;
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
            MovingBD.ItemsSource = Connect.context.Moving.ToList();
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            MovingBD.ItemsSource = Connect.context.Moving.ToList().Select(x => new
            {
                x.IdMoving,
                x.DateMoving,
                IdEmployee = x.Employee.FIO,
                IdPost = x.Post.NamePost,
                x.FromDepartment,
                x.InDepartment
            });
            MessageBox.Show("Фильтрация выполнена", "Фильтрация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
