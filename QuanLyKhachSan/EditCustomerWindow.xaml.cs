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
    /// Interaction logic for EditCustomerWindow.xaml
    /// </summary>
    public partial class EditCustomerWindow : Window
    {
        public string CusId;
        string sex;
        public EditCustomerWindow()
        {
            InitializeComponent();
        }

        private void PreviewTextInputt(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.CUSTOMERs.Where(x => x.CUS_ID == CusId).First();
            a.FULL_NAME = CusName.Text;
            a.CUS_IDENTITY = (byte?)int.Parse(CusIdentity.Text);
            a.NATIONALITY = Nationality.Text;
            a.PHONE = Phone.Text;
            a.CAREER = Career.Text;
            a.SEX = sex;
            a.BIRTHDAY = Birthday.SelectedDate;
            DataProvider.Ins.DB.SaveChanges();

            this.Close();
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
    }
}
