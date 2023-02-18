using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    public class CustomerViewModel : BaseViewModel
    {
        private ObservableCollection<CUSTOMER> _CusmtomerList;
        public ObservableCollection<CUSTOMER> CustomerList { get => _CusmtomerList; set { _CusmtomerList = value; OnPropertyChanged(); } }

        private List<int> _Stt;
        public List<int> Stt { get=> _Stt; set { _Stt = value; OnPropertyChanged(); } }

        public CustomerViewModel()
        {
            CustomerList = new ObservableCollection<CUSTOMER>();
            var customerList = DataProvider.Ins.DB.CUSTOMERs;
            int i = 1;
            Stt = new List<int>();
            foreach (var item in customerList)
            {
                CUSTOMER customer = new CUSTOMER();
                customer = item;
                
                Stt.Add(i);
                CustomerList.Add(customer);
                i++;
            }
        }
    }
}
