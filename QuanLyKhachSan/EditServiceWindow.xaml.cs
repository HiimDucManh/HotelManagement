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
    /// Interaction logic for EditServiceWindow.xaml
    /// </summary>
    public partial class EditServiceWindow : Window
    {
        public EditServiceWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(DataProvider.Ins.DB.STAFFs.Where(x=> x.STAFF_ID == staffID.Text).Count() == 0)
                MessageBox.Show("Mã nhân viên không tồn tại!", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                var a = DataProvider.Ins.DB.HOTELSERVICEs.Where(x => x.SER_ID == serID.Text).First();
                a.FULL_NAME = serName.Text;
                a.STAFF_ID = staffID.Text;
                a.PRICE = int.Parse(price.Text);
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
