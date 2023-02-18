using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    internal class NewStaffViewModel:BaseViewModel
    {
        public ICommand CloseCommand { get; set; }
        public NewStaffViewModel()
        {
            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { p.Close() ; });
        }

    }
}
