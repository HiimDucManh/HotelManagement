using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for NewServicesWindow.xaml
    /// </summary>
    public partial class NewServicesWindow : Window
    {
        public NewServicesWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (DataProvider.Ins.DB.STAFFs.Where(x => x.STAFF_ID == staffID.Text).Count() == 0)
                MessageBox.Show("Mã nhân viên không tồn tại!", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                var ser = new HOTELSERVICE() { SER_ID = serID.Text, STAFF_ID = staffID.Text, FULL_NAME = serName.Text, PRICE = int.Parse(price.Text) };
                DataProvider.Ins.DB.HOTELSERVICEs.Add(ser);
                DataProvider.Ins.DB.SaveChanges();

                this.Close();
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
