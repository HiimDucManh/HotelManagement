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
    /// Interaction logic for EditStaffWindow.xaml
    /// </summary>
    public partial class EditStaffWindow : Window
    {
        public string staffID;
        string sex;
        public EditStaffWindow()
        {
            InitializeComponent();
        }

        private void PreviewTextInputt(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void btnMale_Click(object sender, RoutedEventArgs e)
        {
            if (btnMale.IsChecked == true)
                sex = btnMale.Content.ToString();
        }
        public void btnFeMale_Click(object sender, RoutedEventArgs e)
        {
            if (btnMale.IsChecked == true)
                sex = btnMale.Content.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.STAFFs.Where(x => x.STAFF_ID == staffID).First();
            a.FULL_NAME = staffName.Text;
            a.STAFF_IDENTITY = (byte?)int.Parse(staffIdentity.Text);
            a.STAFF_ADDRESS = address.Text;
            a.PHONE = phone.Text;
            a.SEX = sex;
            a.BIRTHDAY = birthday.SelectedDate;
            DataProvider.Ins.DB.SaveChanges();

            this.Close();
        }
    }
}
