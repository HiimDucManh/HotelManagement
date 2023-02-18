using QuanLyKhachSan.Model;
using QuanLyKhachSan.ViewModel;
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
    /// Interaction logic for PageEmployees.xaml
    /// </summary>
    public partial class PageEmployees : Page
    {
        public PageEmployees()
        {
            InitializeComponent();
        }

        private void Data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var result = new SelectionStaffWindow("Please select!", SelectionStaffWindow.MessageType.Confirmation, SelectionStaffWindow.MessageButtons.EditRemove);
            var a = result.ShowDialog();
            if (result.value != 1)
            {
                if (a.Value)
                {
                    EditStaffWindow editStaffWindow = new EditStaffWindow();
                    STAFF staff = Data.SelectedItem as STAFF;
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
                }
                else
                {
                    STAFF staff = Data.SelectedItem as STAFF;
                    STAFF staffRemove = DataProvider.Ins.DB.STAFFs.Where(x => x.STAFF_ID == staff.STAFF_ID).First();
                    DataProvider.Ins.DB.STAFFs.Remove(staffRemove);
                    DataProvider.Ins.DB.SaveChanges();

                    MessageBox.Show("Successful delete!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
                } 
            }

            Data_Loaded(sender, e);
        }

        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            StaffViewModel a = new StaffViewModel();
            Data.ItemsSource = a.StaffList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewStaffWindow newStaff = new NewStaffWindow();
            newStaff.ShowDialog();

            Data_Loaded(sender, e);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            EditStaffWindow editStaffWindow = new EditStaffWindow();
            STAFF staff = Data.SelectedItem as STAFF;
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

            Data_Loaded(sender, e);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            STAFF staff = Data.SelectedItem as STAFF;
            STAFF staffRemove = DataProvider.Ins.DB.STAFFs.Where(x => x.STAFF_ID == staff.STAFF_ID).First();
            DataProvider.Ins.DB.STAFFs.Remove(staffRemove);
            DataProvider.Ins.DB.SaveChanges();

            MessageBox.Show("Successful delete!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);

            Data_Loaded(sender, e);
        }
    }
}
