using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ViewModel
{
    public class ServicesViewModel : BaseViewModel
    {
        private ObservableCollection<HOTELSERVICE> _ServicesList;
        public ObservableCollection<HOTELSERVICE> ServicesList { get => _ServicesList; set { _ServicesList = value; OnPropertyChanged(); } }

        public ServicesViewModel()
        {
            ServicesList = new ObservableCollection<HOTELSERVICE>();
            var servicesList = DataProvider.Ins.DB.HOTELSERVICEs;
            int i = 1;
            foreach (var item in servicesList)
            {
                HOTELSERVICE services = new HOTELSERVICE();
                services = item;

                ServicesList.Add(services);
                i++;
            }
        }
    }
}
