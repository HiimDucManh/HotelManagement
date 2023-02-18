using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    class BookingViewModel:BaseViewModel
    {
        public bool flag { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand BookCommand { get; set; }
        public ICommand EditCommand { get; set; }

        private string _RoomId { get; set; }
        public string RoomId { get => _RoomId; set { _RoomId = value; OnPropertyChanged(); } }

        private string _CusID { get; set; }
        public string CusID { get => _CusID; set { _CusID = value; OnPropertyChanged(); } }

        private string _CusName { get; set; }
        public string CusName { get => _CusName; set { _CusName = value; OnPropertyChanged(); } }
        private string _SerID { get; set; }
        public string SerID { get => _SerID; set { _SerID = value; OnPropertyChanged(); } }

        private DateTime? _TimeArrival { get; set; }
        public DateTime? TimeArrival { get => _TimeArrival; set { _TimeArrival = value; OnPropertyChanged(); } }

        private DateTime? _TimeLeft { get; set; }
        public DateTime? TimeLeft { get => _TimeLeft; set { _TimeLeft = value; OnPropertyChanged(); } }

        private DateTime? _TimeBook { get; set; }
        public DateTime? TimeBook { get => _TimeBook; set { _TimeBook = value; OnPropertyChanged(); } }

        public BookingViewModel()
        {
            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Close(p); });

            EditCommand = new RelayCommand<Window>((p) => 
            { 
                return 
                true; 
            }, (p) => 
                {

                    Close(p); 
                });
        }
        void Close(Window p)
        {
            p.Close();
        }
    }
}
