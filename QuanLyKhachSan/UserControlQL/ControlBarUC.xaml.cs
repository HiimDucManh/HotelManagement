using QuanLyKho.ViewModel;
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

namespace QuanLyKhachSan.UserControlQL
{
    /// <summary>
    /// Interaction logic for ControlBarUC.xaml
    /// </summary>
    public partial class ControlBarUC : UserControl
    {
        public ControlBarViewModel Viewmodel { get; set; }

        public ControlBarUC()
        {
            InitializeComponent();
            this.DataContext = Viewmodel = new ControlBarViewModel();
        }

        private void ChangedOpacity(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Opacity = 0.5;
            btn.Background = Brushes.Gray;
        }

        private void ReturnOpacity(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Opacity = 1;
            btn.Background = Brushes.Black;
        }
    }
}
