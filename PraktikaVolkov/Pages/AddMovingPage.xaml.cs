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
    /// Логика взаимодействия для AddMovingPage.xaml
    /// </summary>
    public partial class AddMovingPage : Page
    {
        Moving moving;
        bool checkNew;
        public AddMovingPage(Moving a)
        {
            InitializeComponent();
            Empcbx.ItemsSource = Connect.context.Employee.ToList();
            Postcbx.ItemsSource = Connect.context.Post.ToList();
            InDepacbx.ItemsSource = Connect.context.Moving.ToList();
            FromDepacbx.ItemsSource = Connect.context.Moving.ToList();
            if (a == null)
            {
                a = new Moving()
                {
                    DateMoving = DateTime.Now,
                    Employee = Connect.context.Employee.FirstOrDefault(),
                    Post = Connect.context.Post.FirstOrDefault(),
                    Department = Connect.context.Department.FirstOrDefault(),
                    FromDepartment = 1,
                    InDepartment = 1,

                };
                checkNew = true;
            }
            else
                checkNew = false;
            FromDepacbx.ItemsSource = new int[] {1, 2, 3};
            InDepacbx.ItemsSource = new int[] { 1, 2, 3 };
            DataContext = moving = a;
            FromDepacbx.Text =  a.FromDepartment.ToString();
            InDepacbx.Text = a.InDepartment.ToString();
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (textb.Text == "")
            {
                MessageBox.Show("Поле код перемещения не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (datepicker.Text == "")
            {
                MessageBox.Show("Дата перемещения не может быть пустая!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (checkNew)
            {
                Connect.context.Moving.Add(moving);
                MessageBox.Show("Новое перемещение по службе добавлена", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
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
