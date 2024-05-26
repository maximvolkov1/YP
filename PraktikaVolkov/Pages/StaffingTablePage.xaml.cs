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
    /// Логика взаимодействия для StaffingTablePage.xaml
    /// </summary>
    public partial class StaffingTablePage : Page
    {
        public StaffingTablePage()
        {
            InitializeComponent();
            StaffingTableBD.ItemsSource = Connect.context.StaffingTable.ToList();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddStaffingTablePage(null));
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delStaffingTables = StaffingTableBD.SelectedItems.Cast<StaffingTable>().ToList();
            foreach (var delStaffingTable in delStaffingTables)
                if (Connect.context.Employee.Any(x => x.IdStaffingTable == delStaffingTable.IdStaffingTable))
                {
                    MessageBox.Show("Данные используются в таблице Штатное расписание", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {delStaffingTables.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.StaffingTable.RemoveRange(delStaffingTables);
            try
            {
                Connect.context.SaveChanges();
                StaffingTableBD.ItemsSource = Connect.context.StaffingTable.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
            sheet.Name = "Штатное расписание";
            sheet.Cells[1, 1] = "Номер штатного расписания"; sheet.Cells[1, 2] = "Подразделение"; sheet.Cells[1, 3] = "Должность"; sheet.Cells[1, 4] = "Количество сотрудников";
            var currentRow = 2;
            var acceptence = Connect.context.StaffingTable.ToList();
            foreach (var item in acceptence)
            {
                sheet.Cells[currentRow, 1] = item.IdStaffingTable;
                sheet.Cells[currentRow, 2] = item.Department.NameDepartment;
                sheet.Cells[currentRow, 3] = item.Post.NamePost;
                sheet.Cells[currentRow, 4] = item.NumberOfEmployees;
                currentRow++;
                Excel.Range range2 = sheet.get_Range("A1", "D1048576"); range2.Cells.Font.Name = "TimesNewRoman"; range2.Cells.Font.Size = 14;
                range2.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                sheet.Columns.ColumnWidth = 40;
                Excel.Range range3 = sheet.get_Range("A1", "D1"); range3.Cells.Font.Name = "TimesNewRoman"; range3.Cells.Font.Size = 14; range3.Cells.Font.Bold = true;
                range3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StaffingTableBD.ItemsSource = Connect.context.StaffingTable.ToList();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddStaffingTablePage((sender as Button).DataContext as StaffingTable));
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            StaffingTableBD.ItemsSource = Connect.context.StaffingTable.ToList().Select(x => new
            {
                IdStaffingTable = x.IdStaffingTable,
                IdDepartment = x.Department.NameDepartment,
                IdPost = x.Post.NamePost,
                NumberOfEmployees = x.NumberOfEmployees
            });
            MessageBox.Show("Фильтрация выполнена", "Фильтрация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
