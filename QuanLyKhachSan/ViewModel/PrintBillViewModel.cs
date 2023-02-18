using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    public class PrintBillViewModel : BaseViewModel
    {
        private string _RoomID { get; set; }
        public string RoomID { get => _RoomID; set { _RoomID = value; OnPropertyChanged(); } }
        private string _CusID { get; set; }
        public string CusID { get => _CusID; set { _CusID = value; OnPropertyChanged(); } }
        private string _CusName { get; set; }
        public string CusName { get => _CusName; set { _CusName = value; OnPropertyChanged(); } }
        private string _SerID { get; set; }
        public string SerID { get => _SerID; set { _SerID = value; OnPropertyChanged(); } }
        private DateTime _DateBill { get; set; }
        public DateTime DateBill { get => _DateBill; set { _DateBill = value; OnPropertyChanged(); } }
        private double _Cost { get; set; }
        public double Cost { get => _Cost; set { _Cost = value; OnPropertyChanged(); } }
        public ICommand CloseCommand { get; set; }
        public ICommand PayCommand { get; set; }

        private ObservableCollection<BILL> _BillList;
        public ObservableCollection<BILL> BillList { get => _BillList; set { _BillList = value; OnPropertyChanged(); } }

        public PrintBillViewModel()
        {
            BillList = new ObservableCollection<BILL>();
            var billList = DataProvider.Ins.DB.BILLs;


            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { p.Close(); });
            PayCommand = new RelayCommand<Window>((p) => { return true; }, 
                (p) => 
                {
                    

                    p.Close(); 
                });
        }
        void Close(Window p)
        {
            p.Close();
        }
    }
}
