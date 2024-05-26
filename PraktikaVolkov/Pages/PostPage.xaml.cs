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
    /// Логика взаимодействия для PostPage.xaml
    /// </summary>
    public partial class PostPage : Page
    {
        public PostPage()
        {
            InitializeComponent();
            PostLV.ItemsSource = Connect.context.Post.ToList();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddPostPage(null));
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delPosts = PostLV.SelectedItems.Cast<Post>().ToList();
            foreach (var delPost in delPosts)
                if (Connect.context.Employee.Any(x => x.IdPost == delPost.IdPost))
                {
                    MessageBox.Show("Данные используются в таблице Должности", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {delPosts.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Post.RemoveRange(delPosts);
            MessageBox.Show("Запись удалена", "Удаление", MessageBoxButton.OK, MessageBoxImage.Information);
            try
            {
                Connect.context.SaveChanges();
                PostLV.ItemsSource = Connect.context.Post.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            PostLV.ItemsSource = Connect.context.Post.ToList();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddPostPage((sender as Button).DataContext as Post));
        }
    }
}
