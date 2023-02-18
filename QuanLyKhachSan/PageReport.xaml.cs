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
    /// Interaction logic for PageReport.xaml
    /// </summary>
    public partial class PageReport : Page
    {
        public PageReport()
        {
            InitializeComponent();
        }

        public void data_Loaded(object sender, RoutedEventArgs e)
        {
            if (findByDate != null)
                data.ItemsSource = new BillViewModel().BillList;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var billList = DataProvider.Ins.DB.BILLs;
            decimal? s = 0;
            foreach(var item in billList)
            {
                s += item.PRICE;
            }
            sum.Text = s.ToString();
        }

        private void findByDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(findByDate.Text == "")
            {
                data.ItemsSource = new BillViewModel().BillList;
            }
            else
            {
                BillViewModel a = new BillViewModel(findByDate.SelectedDate);
                data.ItemsSource = a.BillList;
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void del_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = new PrintReportWindow();
            a.price.Text = sum.Text;
            a.ShowDialog();
        }
    }
}
