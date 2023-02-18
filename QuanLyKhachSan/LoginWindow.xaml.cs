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
using System.Windows.Shapes;

namespace QuanLyKhachSan
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            LogupWindow logupWindow = new LogupWindow();
            logupWindow.ShowDialog();

            if (logupWindow.flag)
                this.ShowDialog();
        }

        private void PackIcon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void check_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void check_Unchecked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
