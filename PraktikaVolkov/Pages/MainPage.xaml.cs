using PraktikaVolkov.AppData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using Microsoft.Win32;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;

namespace PraktikaVolkov.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void mni1_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new EmployeePage());
        }

        private void mni2_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new PostPage());
        }

        private void mni3_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new DepartmentPage());
        }

        private void mni4_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new StaffingTablePage());
        }

        private void mni5_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AcceptancePage());
        }

        private void mni6_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new DismissalPage());
        }

        private void mni7_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new MovingPage());
        }

        private void mni8_Click(object sender, RoutedEventArgs e)
        {
            var d = new SaveFileDialog();
            d.Filter = "Резервная копия(*.bak)|*.bak|Все файлы(*.*)|*.*";
            bool? res = d.ShowDialog();
            if (res == true)
                Connect.context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
                    $@"BACKUP DATABASE [{Directory.GetCurrentDirectory()}\HR.mdf] TO  " +
                $@"DISK = N'{d.FileName}' WITH NOFORMAT, NOINIT,  " +
                $@"NAME = N'{d.FileName}', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
            MessageBox.Show("Резервная копия сохранена", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
