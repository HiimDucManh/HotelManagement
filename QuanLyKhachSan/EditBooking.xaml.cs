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
    /// Interaction logic for EditBooking.xaml
    /// </summary>
    public partial class EditBooking : Window
    {
        public String Temp;
        public EditBooking()
        {
            InitializeComponent();
        }

        private void PreviewTextInputt(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void EditBookingWindow_Loaded(object sender, RoutedEventArgs e)
        {
            roomID.Text = Temp;
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == Temp);
            if (a.Count() > 0)
            {
                cusID.Text = a.First().CUS_ID;
                cusName.Text = a.First().CUS_NAME;
                timearrival.SelectedDate = a.First().DAY_ARRIVAL;
                serID.Text = a.First().SER_ID;
                timeleft.SelectedDate = a.First().DAY_LEFT;
                timeBook.SelectedDate = a.First().DAY_BOOK;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == roomID.Text);
            if (timeleft.SelectedDate < timearrival.SelectedDate)
                MessageBox.Show("Ngày rời phải lớn hay ngày vào.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            if (DataProvider.Ins.DB.CUSTOMERs.Where(x => x.CUS_ID == cusID.Text).Count() == 0 && cusID.Text != "")
                MessageBox.Show("Mã khách hàng không tồn tại!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            if (DataProvider.Ins.DB.HOTELSERVICEs.Where(x => x.SER_ID == serID.Text).Count() == 0 && serID.Text != "")
                MessageBox.Show("Mã dịch vụ không tồn tại!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                if (cusID.Text == "" && serID.Text != "")
                {
                    a.First().RO_ID = roomID.Text;
                    a.First().CUS_ID = null;
                    a.First().CUS_NAME = cusName.Text;
                    a.First().SER_ID = serID.Text;
                    a.First().DAY_ARRIVAL = timearrival.SelectedDate;
                    a.First().DAY_LEFT = timeleft.SelectedDate;
                    a.First().DAY_LEFT = timeleft.SelectedDate;
                    a.First().DAY_BOOK = timeBook.SelectedDate;
                    a.First().DAY_BOOK = timeBook.SelectedDate;
                }
                else
                if (serID.Text == "" && cusID.Text != "")
                {
                    a.First().RO_ID = roomID.Text;
                    a.First().CUS_ID = cusID.Text;
                    a.First().CUS_NAME = cusName.Text;
                    a.First().SER_ID = null;
                    a.First().DAY_ARRIVAL = timearrival.SelectedDate;
                    a.First().DAY_LEFT = timeleft.SelectedDate;
                    a.First().DAY_LEFT = timeleft.SelectedDate;
                    a.First().DAY_BOOK = timeBook.SelectedDate;
                    a.First().DAY_BOOK = timeBook.SelectedDate;
                }
                else
                if (serID.Text == "" && cusID.Text == "")
                {
                    a.First().RO_ID = roomID.Text;
                    a.First().CUS_ID = null;
                    a.First().CUS_NAME = cusName.Text;
                    a.First().SER_ID = null;
                    a.First().DAY_ARRIVAL = timearrival.SelectedDate;
                    a.First().DAY_LEFT = timeleft.SelectedDate;
                    a.First().DAY_LEFT = timeleft.SelectedDate;
                    a.First().DAY_BOOK = timeBook.SelectedDate;
                    a.First().DAY_BOOK = timeBook.SelectedDate;
                }
                else
                    if (serID.Text != "" && cusID.Text != "")
                {
                    a.First().RO_ID = roomID.Text;
                    a.First().CUS_ID = cusID.Text;
                    a.First().CUS_NAME = cusName.Text;
                    a.First().SER_ID = serID.Text;
                    a.First().DAY_ARRIVAL = timearrival.SelectedDate;
                    a.First().DAY_LEFT = timeleft.SelectedDate;
                    a.First().DAY_LEFT = timeleft.SelectedDate;
                    a.First().DAY_BOOK = timeBook.SelectedDate;
                    a.First().DAY_BOOK = timeBook.SelectedDate;
                }
                DataProvider.Ins.DB.SaveChanges();

                this.Close();
            }
        }
    }
}
