using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Model
{
    public class RoomStatus
    {
        public CUSTOMER Customer { get; set; }
        public BOOKROOM DayArrival { get; set; }
        public BOOKROOM DayLeft     { get; set; }
        public BOOKROOM RoomNumber  { get; set; }


    }
}
