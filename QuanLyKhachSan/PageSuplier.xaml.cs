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
    /// Interaction logic for PageSuplier.xaml
    /// </summary>
    public partial class PageSuplier : Page
    {
        public PageSuplier()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewServicesWindow newSer = new NewServicesWindow();
            newSer.ShowDialog();
            data_Loaded(sender, e);
        }

        private void data_Loaded(object sender, RoutedEventArgs e)
        {
            ServicesViewModel a = new ServicesViewModel();
            data.ItemsSource = a.ServicesList;
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var result = new SelectionStaffWindow("Please, select!", SelectionStaffWindow.MessageType.Confirmation, SelectionStaffWindow.MessageButtons.EditRemove);
            var a = result.ShowDialog();
            if (result.value != 1)
            {
                if (a.Value == true)
                {
                    EditServiceWindow editService = new EditServiceWindow();
                    HOTELSERVICE ser = data.SelectedItem as HOTELSERVICE;
                    editService.serID.Text = ser.SER_ID;
                    editService.serName.Text = ser.FULL_NAME;
                    editService.staffID.Text = ser.STAFF_ID;
                    editService.price.Text = ser.PRICE.ToString();
                    editService.ShowDialog();
                }
                else
                {
                    HOTELSERVICE ser = data.SelectedItem as HOTELSERVICE;
                    HOTELSERVICE service = DataProvider.Ins.DB.HOTELSERVICEs.Where(x => x.SER_ID == ser.SER_ID).First();
                    DataProvider.Ins.DB.HOTELSERVICEs.Remove(service);
                    DataProvider.Ins.DB.SaveChanges();

                    MessageBox.Show("Successful delete!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
                } 
            }
            data_Loaded(sender, e);
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            EditServiceWindow editService = new EditServiceWindow();
            HOTELSERVICE ser = data.SelectedItem as HOTELSERVICE;
            editService.serID.Text = ser.SER_ID;
            editService.serName.Text = ser.FULL_NAME;
            editService.staffID.Text = ser.STAFF_ID;
            editService.price.Text = ser.PRICE.ToString();
            editService.ShowDialog();

            data_Loaded(sender, e);
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            HOTELSERVICE ser = data.SelectedItem as HOTELSERVICE;
            HOTELSERVICE service = DataProvider.Ins.DB.HOTELSERVICEs.Where(x => x.SER_ID == ser.SER_ID).First();
            DataProvider.Ins.DB.HOTELSERVICEs.Remove(service);
            DataProvider.Ins.DB.SaveChanges();

            MessageBox.Show("Successful delete!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);

            data_Loaded(sender, e);
        }
    }
}
