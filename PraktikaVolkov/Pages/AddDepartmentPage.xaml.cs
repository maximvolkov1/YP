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
    /// Логика взаимодействия для AddDepartmentPage.xaml
    /// </summary>
    public partial class AddDepartmentPage : Page
    {

        Department deportment;
        bool checkNew;
        public AddDepartmentPage(Department a)
        {
            InitializeComponent();
            if (a == null)
            {
                a = new Department();
                checkNew = true;
            }
            else
                checkNew = false;
            DataContext = deportment = a;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (textb1.Text == "" || textb2.Text == "")
            {
                MessageBox.Show("Проверьте правильность заполнения полей!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (checkNew)
            {
                Connect.context.Department.Add(deportment);
                MessageBox.Show("Новое подразделение добавлено", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            try
            {
                Connect.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Nav.MainFrame.GoBack();
        }


        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
    }
}
