using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace QuanLyKhachSan.ViewModel
{
    public class NewCustomerViewModel : BaseViewModel
    {
        public bool flag { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        private string _CusIdentity { get; set; }
        public string CusIdentity { get => _CusIdentity; set { _CusIdentity = value; OnPropertyChanged(); } }

        private string _Phone { get; set; }
        public string Phone { get => _Phone; set { _Phone = value; OnPropertyChanged(); } }

        private string _CusName { get; set; }
        public string CusName { get => _CusName; set { _CusName = value; OnPropertyChanged(); } }

        private DateTime? _Birthday { get; set; }
        public DateTime? Birthday { get => _Birthday; set { _Birthday = value; OnPropertyChanged(); } }
        private string _Nationality { get; set; }
        public string Nationality { get => _Nationality; set { _Nationality = value; OnPropertyChanged(); } }
        private string _Career { get; set; }
        public string Career { get => _Career; set { _Career = value; OnPropertyChanged(); } }



        public NewCustomerViewModel()
        {
            
            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Close(p); });
        }



        void Close(Window p)
        {
            p.Close();
        }
    }
}
