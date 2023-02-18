using Microsoft.Win32;
using NetTopologySuite.Utilities;
using QuanLyKhachSan.Model;
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
    /// Interaction logic for PageUser.xaml
    /// </summary>
    public partial class PageUser : Page
    {
        public PageUser()
        {
            InitializeComponent();
        }

        public string ID { get; set; }

        private void signOutBtn_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            //LoginWindow loginWindow = new LoginWindow();
            //loginWindow.ShowDialog();   
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == ID);
            if (b.First().SOURCES != null)
            {
                Uri fileUri = new Uri(b.First().SOURCES);
                ava.ImageSource = new BitmapImage(fileUri); 
            }

            var a = DataProvider.Ins.DB.STAFFs.Where(x => x.STAFF_ID == b.FirstOrDefault().STAFF_ID);
            if (a.Count() > 0)
            {
                name.Text = a.First().FULL_NAME;
                birthday.Text = a.First().BIRTHDAY.Value.Day.ToString() + "/" + a.First().BIRTHDAY.Value.Month.ToString() + "/" + a.First().BIRTHDAY.Value.Year.ToString();
                sex.Text = a.First().SEX;
                phone.Text = a.First().PHONE;
                address.Text = a.First().STAFF_ADDRESS;
                position.Text = a.First().POSITION;
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditStaffWindow editStaffWindow = new EditStaffWindow();
            var b = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == ID);
            var staff = DataProvider.Ins.DB.STAFFs.Where(x => x.STAFF_ID == b.FirstOrDefault().STAFF_ID).First();
            editStaffWindow.staffName.Text = staff.FULL_NAME;
            editStaffWindow.staffIdentity.Text = staff.STAFF_IDENTITY.ToString();
            editStaffWindow.phone.Text = staff.PHONE;
            editStaffWindow.birthday.SelectedDate = staff.BIRTHDAY;
            if (staff.SEX != null)
            {
                if (editStaffWindow.btnMale.Content.ToString() == staff.SEX)
                {
                    editStaffWindow.btnMale.IsChecked = true;
                }
                else editStaffWindow.btnFemale.IsChecked = true;
            }
            editStaffWindow.address.Text = staff.STAFF_ADDRESS;
            editStaffWindow.staffID = staff.STAFF_ID;
            editStaffWindow.ShowDialog();

            Page_Loaded(sender, e);
        }

        private void changePassword_Click(object sender, RoutedEventArgs e)
        {
            var a = new ChangePasswordWindow();
            a.ID = ID;
            a.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                //avatar.Source = new BitmapImage(fileUri);
                ava.ImageSource = new BitmapImage(fileUri);
                var a = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == ID);
                a.First().SOURCES = ava.ImageSource.ToString();
            }
        }
    }
}
