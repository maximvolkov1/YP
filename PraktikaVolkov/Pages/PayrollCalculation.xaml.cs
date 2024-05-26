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
    /// Логика взаимодействия для PayrollCalculation.xaml
    /// </summary>
    public partial class PayrollCalculation : Page
    {
        public PayrollCalculation()
        {
            InitializeComponent();
            decimal ndfl = 0.13m;
            var payrollEmployees = Connect.context.Salary.Select(x => new
            {
                salary = x.Salary1,
                Payroll = (x.Salary1 * ndfl),
            }).ToList();
            payrollEmployeesBD.ItemsSource = Connect.context.Salary.ToList();
            payrollEmployeesBD.ItemsSource = payrollEmployees;
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
    }
}
