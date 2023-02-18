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
    /// Interaction logic for NewCustomerWindow.xaml
    /// </summary>
    public partial class NewCustomerWindow : Window
    {
        public string Temp { get; set; }
        public NewCustomerWindow()
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
            int x = DataProvider.Ins.DB.CUSTOMERs.Count();
            //string sex = tempp.Temp;
            x++;
            string i = "KH" + (x).ToString();
            var Save = new CUSTOMER() { CUS_ID = i, FULL_NAME = CusName.Text, CUS_IDENTITY = (byte?)int.Parse(CusIdentity.Text), PHONE = Phone.Text, BIRTHDAY = Birthday.SelectedDate, SEX = Temp, NATIONALITY = Nationality.Text, CAREER = Career.Text };
            DataProvider.Ins.DB.CUSTOMERs.Add(Save);
            DataProvider.Ins.DB.SaveChanges();

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
