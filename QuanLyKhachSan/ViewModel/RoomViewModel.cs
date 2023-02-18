using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    public class RoomViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public DateTime TimeArrival    { get; set; }
        public DateTime TimeLeft { get; set; }


    }
}
