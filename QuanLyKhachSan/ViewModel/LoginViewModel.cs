using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        public bool IsLogin { get; set; }
        public string Staff_Id { get; set; }
        public string US_ID;
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        public ICommand CloseCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand LogupCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        // mọi thứ xử lý sẽ nằm trong này
        public LoginViewModel()
        {
            IsLogin = false;
            Password = "";
            UserName = "";
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Login(p); });
            LogupCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Logup(p); });
            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { p.Close(); });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
        }

        void Login(Window p)
        {
            if (p == null)
            {
                return;
            }

            /*
             admin
             admin
             */

            //string passEncode = MD5Hash(Base64Encode(Password));

            //var accCount = DataProvider.Ins.DB.USERS.Where(x => x.US_USERNAME == UserName && x.US_PASSWORD == passEncode); 

            //if (accCount.Count() > 0)
            //{
            //    IsLogin = true;
            //    Staff_Id = accCount.First().STAFF_ID;
            //    US_ID = accCount.First().US_ID;
            //    p.Close();
            //}
            //else
            //{

            //    IsLogin = false;
            //    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            //}

            if (UserName == "admin" && Password == "admin")
            {
                IsLogin = true;

                p.Close();
            }
            else
            {
                IsLogin = false;
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
        void Logup(Window p)
        {
            if (p == null)
            {
                return;
            }

            p.Hide();

            LogupWindow logupWindow = new LogupWindow();
            logupWindow.ShowDialog();

            if (logupWindow.DataContext == null)
            {
                return;
            }

            var loginVM = logupWindow.DataContext as LogupViewModel;

            if (loginVM.flag)
            {
                logupWindow.Close();
                p.Show();
                
            }
            else
            {
                p.Close();
            }
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
