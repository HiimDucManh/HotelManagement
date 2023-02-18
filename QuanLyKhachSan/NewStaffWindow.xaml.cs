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
    /// Interaction logic for NewStaffWindow.xaml
    /// </summary>
    public partial class NewStaffWindow : Window
    {
        public string Temp { get; set; }
        public NewStaffWindow()
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
                Temp = btnMale.Content.ToString();
        }
        public void btnFeMale_Click(object sender, RoutedEventArgs e)
        {
            if (btnMale.IsChecked == true)
                Temp = btnMale.Content.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = DataProvider.Ins.DB.STAFFs.Count();
            //string sex = tempp.Temp;
            x++;
            string i = "NV" + (x).ToString();
            var Save = new STAFF() { STAFF_ID = i, FULL_NAME = CusName.Text, STAFF_IDENTITY = (byte?)int.Parse(CusIdentity.Text), PHONE = Phone.Text, BIRTHDAY = Birthday.SelectedDate, SEX = Temp, STAFF_ADDRESS = address.Text};
            DataProvider.Ins.DB.STAFFs.Add(Save);
            DataProvider.Ins.DB.SaveChanges();

            this.Close();
        }
    }
}
