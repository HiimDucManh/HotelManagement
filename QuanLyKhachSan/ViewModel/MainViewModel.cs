using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<RoomStatus> _RoomStatus;
        public ObservableCollection<RoomStatus> RoomStatus { get => _RoomStatus; set { _RoomStatus = value; OnPropertyChanged();  } }
        public bool Isloaded = false;
        private string _ID { get; set; }
        public string ID { get=> _ID; set { _ID = value; OnPropertyChanged(); } }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand LoadedBookingWindowCommand { get; set; }
        public ICommand LogoutUserCommand { get; set; }
        public ICommand SignOutCommand { get; set; }
        public MainViewModel()
        {
            SignOutCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { p.Close(); });
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                Isloaded = true;
                if (p == null)
                    return;
                p.Hide();
                LoginWindow loginWindow = new LoginWindow();
                _ = loginWindow.ShowDialog();

                if (loginWindow.DataContext == null)
                {
                    return;
                }

                var loginVM = loginWindow.DataContext as LoginViewModel;

                if (loginVM.IsLogin)
                {
                    loginWindow.Hide();
                    ID = loginVM.US_ID;
                    p.Show();
                    
                }
                else
                {
                    p.Close();
                }
            }
            );
            LoadedBookingWindowCommand = new RelayCommand<Page>((p) => { return true; }, (p) =>
            {
                if (p == null)
                    return;

                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.ShowDialog();

                if (roomBookWindow.DataContext == null)
                {
                    return;
                }

                var loginVM = roomBookWindow.DataContext as BookingViewModel;

                if (loginVM.flag)
                {
                    roomBookWindow.Hide();
                }
            }
            );
        }
    }
}
