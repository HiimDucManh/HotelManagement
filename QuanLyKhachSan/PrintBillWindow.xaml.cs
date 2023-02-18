using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace QuanLyKhachSan
{
    /// <summary>
    /// Interaction logic for PrintBillWindow.xaml
    /// </summary>
    public partial class PrintBillWindow : Window
    {
        public string ID;
        List<String> data;

        public PrintBillWindow()
        {
            InitializeComponent();

        }

        private void printBillWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == ID);
            cusName.Text = a.First().CUS_NAME;
            cusID.Text = a.First().CUS_ID;
            dateBill.Text = DateTime.Now.ToString();
            invoiceNo.Text = (DataProvider.Ins.DB.BILLs.Count() + 1).ToString();
            data = new List<string>();
            nameCL.Header = a.First().SER_ID;
            var b = DataProvider.Ins.DB.ROOMs.Where(x => x.RO_ID == ID);
            var c = DataProvider.Ins.DB.HOTELSERVICEs.Where(x => x.SER_ID == nameCL.Header.ToString());
            var sum = (a.First().DAY_ARRIVAL.Value.Hour - a.First().DAY_LEFT.Value.Hour) * b.First().PRICE_HOUR;
            if (c.Count() > 0)
                sum += c.First().PRICE;
            price.Text = sum.ToString();
            priceCL.Header = c.First().PRICE;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
