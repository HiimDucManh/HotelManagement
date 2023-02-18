using QuanLyKhachSan.Model;
using QuanLyKhachSan.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for PageCustomer.xaml
    /// </summary>
    public partial class PageCustomer : Page
    {
        public PageCustomer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewCustomerWindow newCustomerWindow = new NewCustomerWindow();
            newCustomerWindow.ShowDialog();
            DataGrid_Loaded(sender, e);
        }

        void Close(Window p)
        {
            p.Close();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerViewModel a = new CustomerViewModel();
            Data.ItemsSource = a.CustomerList;
            
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var result = new SelectionStaffWindow("Please, select!", SelectionStaffWindow.MessageType.Confirmation, SelectionStaffWindow.MessageButtons.EditRemove);
            var a = result.ShowDialog();
            if (result.value != 1)
            {
                if (a == true)
                {
                    EditCustomerWindow editCustomerWindow = new EditCustomerWindow();
                    CUSTOMER cus = Data.SelectedItem as CUSTOMER;
                    editCustomerWindow.CusName.Text = cus.FULL_NAME;
                    editCustomerWindow.CusIdentity.Text = cus.CUS_IDENTITY.ToString();
                    editCustomerWindow.Phone.Text = cus.PHONE;
                    editCustomerWindow.Birthday.SelectedDate = cus.BIRTHDAY;
                    if (cus.SEX != null)
                    {
                        if (editCustomerWindow.btnMale.Content.ToString() == cus.SEX)
                        {
                            editCustomerWindow.btnMale.IsChecked = true;
                        }
                        else editCustomerWindow.btnFemale.IsChecked = true;
                    }
                    editCustomerWindow.Nationality.Text = cus.NATIONALITY;
                    editCustomerWindow.Career.Text = cus.CAREER;
                    editCustomerWindow.CusId = cus.CUS_ID;
                    editCustomerWindow.ShowDialog();
                }
                else
                {
                    CUSTOMER cus = Data.SelectedItem as CUSTOMER;
                    CUSTOMER customer = DataProvider.Ins.DB.CUSTOMERs.Where(x => x.CUS_ID == cus.CUS_ID).First();
                    DataProvider.Ins.DB.CUSTOMERs.Remove(customer);
                    DataProvider.Ins.DB.SaveChanges();

                    MessageBox.Show("Successful delete!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
                } 
            }
            DataGrid_Loaded(sender, e);
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            EditCustomerWindow editCustomerWindow = new EditCustomerWindow();
            CUSTOMER cus = Data.SelectedItem as CUSTOMER;
            editCustomerWindow.CusName.Text = cus.FULL_NAME;
            editCustomerWindow.CusIdentity.Text = cus.CUS_IDENTITY.ToString();
            editCustomerWindow.Phone.Text = cus.PHONE;
            editCustomerWindow.Birthday.SelectedDate = cus.BIRTHDAY;
            if (cus.SEX != null)
            {
                if (editCustomerWindow.btnMale.Content.ToString() == cus.SEX)
                {
                    editCustomerWindow.btnMale.IsChecked = true;
                }
                else editCustomerWindow.btnFemale.IsChecked = true;
            }
            editCustomerWindow.Nationality.Text = cus.NATIONALITY;
            editCustomerWindow.Career.Text = cus.CAREER;
            editCustomerWindow.CusId = cus.CUS_ID;
            editCustomerWindow.ShowDialog();
            DataGrid_Loaded(sender, e);
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            CUSTOMER cus = Data.SelectedItem as CUSTOMER;
            CUSTOMER customer = DataProvider.Ins.DB.CUSTOMERs.Where(x => x.CUS_ID == cus.CUS_ID).First();
            DataProvider.Ins.DB.CUSTOMERs.Remove(customer);
            DataProvider.Ins.DB.SaveChanges();

            MessageBox.Show("Successful delete!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            DataGrid_Loaded(sender, e);
        }
    }
}
