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
    public class UserViewModel:BaseViewModel
    {
        public ICommand SignOutCommand  { get; set; }
        private string _Name { get; set; }
        public string Name { get { return _Name;} set { _Name = value; OnPropertyChanged(); } }
        private DateTime _Birthday { get; set; }
        public DateTime Birthday { get { return _Birthday; } set { _Birthday = value; OnPropertyChanged(); } }
        private string _Sex { get; set; }
        public string Sex { get { return _Sex; } set { _Sex = value; OnPropertyChanged(); } }
        private string _Phone { get; set; }
        public string Phone { get { return _Phone; } set { _Phone = value; OnPropertyChanged(); } }
        private string _Address { get; set; }
        public string Address { get { return _Address; } set { _Address = value; OnPropertyChanged(); } }
        private string _Position { get; set; }
        public string Position { get { return _Position; } set { _Position = value; OnPropertyChanged(); } }
        public UserViewModel()
        {
            
        }
    }
}
