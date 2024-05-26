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
    /// Логика взаимодействия для AddDismissalPage.xaml
    /// </summary>
    public partial class AddDismissalPage : Page
    {
        Dismissal dismissal;
        bool checkNew;
        public AddDismissalPage(Dismissal a)
        {
            InitializeComponent();
            Empcbx.ItemsSource = Connect.context.Employee.ToList();
            Postcbx.ItemsSource = Connect.context.Post.ToList();
            Depacbx.ItemsSource = Connect.context.Department.ToList();
            Reasoncbx.ItemsSource = Connect.context.Dismissal.ToList();
            if (a == null)
            {
                a = new Dismissal()
                {
                    ReasonForDismissal = "По собственному желанию",
                    DateDismissal = DateTime.Now,
                    Employee = Connect.context.Employee.FirstOrDefault(),
                    Post = Connect.context.Post.FirstOrDefault(),
                    Department = Connect.context.Department.FirstOrDefault()
                    
                };
                checkNew = true;
            }
            else
                checkNew = false;
            Reasoncbx.ItemsSource = new string[] { "По собственному желанию", "Прогул", "Приход на работу в нетрезвом виде", "Хищение или растрата", "Другая причина"};
            Reasoncbx.Text = a.ReasonForDismissal;
            DataContext = dismissal = a;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (datepicker.Text == "")
            {
                MessageBox.Show("Поле дата увольнения не дожно быть пустым!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (textb1.Text == "")
            {
                MessageBox.Show("Поле код увольнения не должно быть пустым!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (checkNew)
            {
                Connect.context.Dismissal.Add(dismissal);
                MessageBox.Show("Новое увольнение с работы добавлено", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
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
