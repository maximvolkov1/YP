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
    /// Логика взаимодействия для AddPostPage.xaml
    /// </summary>
    public partial class AddPostPage : Page
    {
        Post post;
        bool checkNew;
        public AddPostPage(Post a)
        {
            InitializeComponent();
            if (a == null)
            {
                a = new Post();
                checkNew = true;
            }
            else
                checkNew = false;
            DataContext = post = a;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (textb1.Text == "" || textb2.Text == "")
            {
                MessageBox.Show("Проверьте правильность заполнения полей!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (checkNew)
            {
                Connect.context.Post.Add(post);
                MessageBox.Show("Новая должность добавлена", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
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
