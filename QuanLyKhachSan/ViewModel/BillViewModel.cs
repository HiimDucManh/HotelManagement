using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ViewModel
{
    public class BillViewModel : BaseViewModel
    {
        private ObservableCollection<BILL> _BillList;
        public ObservableCollection<BILL> BillList { get => _BillList; set { _BillList = value; OnPropertyChanged(); } }
        private DateTime? _FindDate { get; set; }
        public DateTime? FindDate { get => _FindDate; set { _FindDate = value; OnPropertyChanged(); } }
        

        public BillViewModel()
        {
                BillList = new ObservableCollection<BILL>();
                var billList = DataProvider.Ins.DB.BILLs;
                var cusList = DataProvider.Ins.DB.CUSTOMERs;
                int i = 1;
                foreach (var item in billList)
                {
                    BILL bill = new BILL();
                    bill = item;
              
                    
                    BillList.Add(bill);
                    i++;
                } 
            
        }
        public BillViewModel(DateTime? dateTime)
        {
            BillList = new ObservableCollection<BILL>();
            var billList = DataProvider.Ins.DB.BILLs.Where(x => x.BILL_DATE.Value.Day == dateTime.Value.Day && x.BILL_DATE.Value.Month == dateTime.Value.Month && x.BILL_DATE.Value.Year == dateTime.Value.Year);
            var cusList = DataProvider.Ins.DB.CUSTOMERs;
            int i = 1;
            foreach (var item in billList)
            {
                BILL bill = new BILL();
                bill = item;
                bill.STT = i;
                
                BillList.Add(bill);
                i++;
            }
        }
    }
}
