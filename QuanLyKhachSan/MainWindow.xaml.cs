using QuanLyKhachSan.Model;
using QuanLyKhachSan.ViewModel;
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

namespace QuanLyKhachSan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnroomDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainContentWindow.Content = new PageRoom();
        }
        private void btncustomerDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainContentWindow.Content = new PageCustomer();
        }
        private void btnemployeesDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //var a = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == user.DataContext.ToString());
            //if (a.First().ROLE_ID == 1)
            //{
                PageEmployees p = new PageEmployees();
            var a = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == user.DataContext.ToString());
            int? temp = a.First().ROLE_ID;
            if (temp == 1)
                p.IsEnabled = true;
            else p.IsEnabled = false;
            MainContentWindow.Content = p;
            //}
            //else MessageBox.Show("Do not have permission!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void btnReportDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //var a = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == user.DataContext.ToString());
            //if (a.First().ROLE_ID == 1)
            //{
                PageReport t = new PageReport();
                t.data_Loaded(sender, e);
            var a = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == user.DataContext.ToString());
            if (a.First().ROLE_ID == 1)
                t.IsEnabled = true;
            else t.IsEnabled = false;
            MainContentWindow.Content = t;
            //}
            //else MessageBox.Show("Do not have permission!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        private void btnUserDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PageUser t = new PageUser();
            t.ID = user.DataContext as string;
            MainContentWindow.Content = t;
        }
        private void btnSuplierDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //var a = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == user.DataContext.ToString());
            //if (a.First().ROLE_ID == 1)
            //{
                PageSuplier p = new PageSuplier();
                var a = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == user.DataContext.ToString());
                if (a.First().ROLE_ID == 1)
                    p.IsEnabled = true;
                else p.IsEnabled = false;
                MainContentWindow.Content = p;
            //}
            //else MessageBox.Show("Do not have permission!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void Move_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else
                Application.Current.MainWindow.WindowState = WindowState.Normal;
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void signOut_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            var a = new MainWindow();
            a.ShowDialog();
            this.Close();
        }

        private void Mainwindow_Loaded(object sender, RoutedEventArgs e)
        {
            //var a = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == user.DataContext.ToString());
            //if (a.First().ROLE_ID == 1)
            //{ 
            //    btnReport.IsEnabled = true;
            //}
            //else
            //{
            //    btnReport.IsEnabled = false;
            //}
        }
    }
}
