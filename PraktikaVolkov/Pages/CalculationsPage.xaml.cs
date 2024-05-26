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

namespace PraktikaVolkov.Pages
{
    /// <summary>
    /// Логика взаимодействия для CalculationsPage.xaml
    /// </summary>
    public partial class CalculationsPage : Page
    {
        public CalculationsPage()
        {
            InitializeComponent();
            decimal ndfl =  0.13m;
            EmployeeBD.ItemsSource = Connect.context.Employee.Select(x => new
            {
                x.IdEmployee,
                x.FIO,
                x.BirthDate,
                x.Gender,
                x.Addres,
                x.Phone,
                x.Education,
                x.DateAcceptence,
                x.DateDismissal,
                x.DateMoving,
                x.IdPost,
                x.IdDepartment,
                x.IdStaffingTable,
                x.Salary,
                x.DaysWorked,
                Tobepaid = (x.Salary / x.DaysWorked * x.DaysWorked) - (x.Salary * ndfl)
            }).ToList();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
    }
}
