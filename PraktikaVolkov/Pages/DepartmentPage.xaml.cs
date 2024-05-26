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
    /// Логика взаимодействия для DepartmentPage.xaml
    /// </summary>
    public partial class DepartmentPage : Page
    {
        public DepartmentPage()
        {
            InitializeComponent();
            DepartmentLV.ItemsSource = Connect.context.Department.ToList();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddDepartmentPage(null));
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delDeportments = DepartmentLV.SelectedItems.Cast<Department>().ToList();
            foreach (var delDeportment in delDeportments)
                if (Connect.context.Employee.Any(x => x.IdDepartment == delDeportment.IdDepartment))
                {
                    MessageBox.Show("Данные используются в таблице Подразделения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {delDeportments.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Department.RemoveRange(delDeportments);
                MessageBox.Show("Запись удалена", "Удаление", MessageBoxButton.OK, MessageBoxImage.Information);
            try
            {
                Connect.context.SaveChanges();
                DepartmentLV.ItemsSource = Connect.context.Department.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            DepartmentLV.ItemsSource = Connect.context.Department.ToList();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddDepartmentPage((sender as Button).DataContext as Department));
        }
    }
}
