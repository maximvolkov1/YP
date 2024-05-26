using PraktikaVolkov.AppData;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using Button = System.Windows.Controls.Button;
using Excel = Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;
namespace PraktikaVolkov.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddEmployeePage(null));
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delEmployees = EmployeeBD.SelectedItems.Cast<Employee>().ToList();
            foreach (var delEmployee in delEmployees)
                if (Connect.context.Employee.Any(x => x.IdEmployee == delEmployee.IdEmployee))
                {
                    MessageBox.Show("Данные используются в таблице Сотрудники", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {delEmployees.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Employee.RemoveRange(delEmployees);
            try
            {
                Connect.context.SaveChanges();
                EmployeeBD.ItemsSource = Connect.context.Employee.ToList();
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeBD.ItemsSource = Connect.context.Employee.ToList();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddEmployeePage((sender as Button).DataContext as Employee));
        }

        private void searchtb_TextChanged(object sender, TextChangedEventArgs e)
        {
            EmployeeBD.ItemsSource = Connect.context.Employee.Where(x => x.FIO.StartsWith(searchtb.Text)).ToList();
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
            sheet.Name = "Сотрудники";
            sheet.Cells[1, 1] = "Id сотрудника"; sheet.Cells[1, 2] = "ФИО"; sheet.Cells[1, 3] = "Дата рождения"; sheet.Cells[1, 4] = "Пол";
            sheet.Cells[1, 5] = "Адрес"; sheet.Cells[1, 6] = "Телефон"; sheet.Cells[1, 7] = "Образование"; sheet.Cells[1, 8] = "Id должности";
            sheet.Cells[1, 9] = "Id подразделения"; sheet.Cells[1, 10] = "Дата принятия"; sheet.Cells[1, 11] = "Дата увольнения"; sheet.Cells[1, 12] = "Дата перемещения";
            sheet.Cells[1, 13] = "Оклад"; sheet.Cells[1, 14] = "Количество отработанных дней"; sheet.Cells[1, 15] = "Итого к выплате";
            var currentRow = 2;
            var employee = Connect.context.Employee.ToList();
            foreach (var item in employee)
            {
                sheet.Cells[currentRow, 1] = item.IdEmployee;
                sheet.Cells[currentRow, 2] = item.FIO;
                sheet.Cells[currentRow, 3] = item.BirthDate;
                sheet.Cells[currentRow, 4] = item.Gender;
                sheet.Cells[currentRow, 5] = item.Addres;
                sheet.Cells[currentRow, 6] = item.Phone;
                sheet.Cells[currentRow, 7] = item.Education;
                sheet.Cells[currentRow, 8] = item.IdPost;
                sheet.Cells[currentRow, 9] = item.IdDepartment;
                sheet.Cells[currentRow, 10] = item.DateAcceptence;
                sheet.Cells[currentRow, 11] = item.DateDismissal;
                sheet.Cells[currentRow, 12] = item.DateMoving;
                sheet.Cells[currentRow, 13] = item.Salary;
                sheet.Cells[currentRow, 14] = item.DaysWorked;
                currentRow++;
                Excel.Range range2 = sheet.get_Range("A1", "O1048576"); range2.Cells.Font.Name = "TimesNewRoman"; range2.Cells.Font.Size = 14;
                range2.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                sheet.Columns.ColumnWidth = 48;
                Excel.Range range3 = sheet.get_Range("A1", "O1"); range3.Cells.Font.Name = "TimesNewRoman"; range3.Cells.Font.Size = 14; range3.Cells.Font.Bold = true;
                range3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                Excel.Borders borders1 = range2.Borders;
                borders1.LineStyle = Excel.XlLineStyle.xlContinuous;
                borders1.Weight = 2d;
                sheet.Cells[2, 15].FormulaLocal = "=(M2/N2 * N2) - (M2 * 0,13)";
                sheet.Cells[3, 15].FormulaLocal = "=(M3/N3 * N3) - (M3 * 0,13)";
                sheet.Cells[4, 15].FormulaLocal = "=(M4/N4 * N4) - (M4 * 0,13)";
                sheet.Cells[5, 15].FormulaLocal = "=(M5/N5 * N5) - (M5 * 0,13)";
                sheet.Cells[6, 15].FormulaLocal = "=(M6/N6 * N6) - (M6 * 0,13)";
                sheet.Cells[7, 15].FormulaLocal = "=(M7/N7 * N7) - (M7 * 0,13)";
                sheet.Cells[8, 15].FormulaLocal = "=(M8/N8 * N8) - (M8 * 0,13)";
                sheet.Cells[9, 15].FormulaLocal = "=(M9/N9 * N9) - (M9 * 0,13)";
                sheet.Cells[10, 15].FormulaLocal = "=(M10/N10 * N10) - (M10 * 0,13)";
                sheet.Cells[11, 15].FormulaLocal = "=(M11/N11 * N11) - (M11 * 0,13)";
                sheet.Cells[12, 15].FormulaLocal = "=(M12/N12 * N12) - (M12 * 0,13)";
                sheet.Cells[13, 15].FormulaLocal = "=(M13/N13 * N13) - (M13 * 0,13)";
                sheet.Cells[14, 15].FormulaLocal = "=(M14/N14 * N14) - (M14 * 0,13)";
                sheet.Cells[15, 15].FormulaLocal = "=(M15/N15 * N15) - (M15 * 0,13)";
            }
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            EmployeeBD.ItemsSource = Connect.context.Employee.ToList().Select(x => new
            {
                IdEmployee = x.IdEmployee,
                FIO = x.FIO,
                BirthDate = x.BirthDate,
                Gender = x.Gender,
                Addres = x.Addres,
                Phone = x.Phone,
                Education = x.Education,
                IdPost = x.Post.NamePost,
                IdDepartment = x.Department.NameDepartment,
                IdStaffingTable = x.StaffingTable.IdStaffingTable,
                DateAcceptence = x.DateAcceptence,
                DateDismissal = x.DateDismissal,
                DateMoving = x.DateMoving,
                Salary = x.Salary,
                DaysWorked = x.DaysWorked
            });
            MessageBox.Show("Фильтрация выполнена", "Фильтрация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void calc_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new CalculationsPage());
        }
    }
}
