using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ViewModel
{
    public class StaffViewModel : BaseViewModel
    {
        private ObservableCollection<STAFF> _StaffList;
        public ObservableCollection<STAFF> StaffList { get => _StaffList; set { _StaffList = value; OnPropertyChanged(); } }

        public StaffViewModel()
        {
            StaffList = new ObservableCollection<STAFF>();
            var staffList = DataProvider.Ins.DB.STAFFs;
            int i = 1;
            foreach (var item in staffList)
            {
                STAFF staff = new STAFF();
                staff = item;
             
                StaffList.Add(staff);
                i++;
            }
        }
    }
}
