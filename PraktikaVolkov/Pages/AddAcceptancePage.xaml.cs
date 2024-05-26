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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace PraktikaVolkov.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddAcceptancePage.xaml
    /// </summary>
    public partial class AddAcceptancePage : Page
    {
        Acceptence acceptance;
        bool checkNew;
        public AddAcceptancePage(Acceptence a)
        {
            InitializeComponent();
            Empcbx.ItemsSource = Connect.context.Employee.ToList();
            Postcbx.ItemsSource = Connect.context.Post.ToList();
            Depacbx.ItemsSource = Connect.context.Department.ToList();
            if (a == null)
            {
                a = new Acceptence()
                { 
                    DateAcceptance = DateTime.Now,
                    Employee = Connect.context.Employee.FirstOrDefault(),
                    Post = Connect.context.Post.FirstOrDefault(),
                    Department = Connect.context.Department.FirstOrDefault()
                };

                checkNew = true;
            }
            else
                checkNew = false;
            DataContext = acceptance = a;
        }
        

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (textb.Text == "")
            {
                MessageBox.Show("Поле код принятия не должно быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datepicker.Text == "")
            {
                MessageBox.Show("Дата принятия не должна быть пустой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (checkNew)
            {
                Connect.context.Acceptence.Add(acceptance);
                MessageBox.Show("Новое принятие на работу добавлено", "Добавление", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
            }
            try
            {
                Connect.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }
            Nav.MainFrame.GoBack();
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
    }
}
