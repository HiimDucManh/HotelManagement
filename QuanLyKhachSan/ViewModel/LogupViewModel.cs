using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    public class LogupViewModel : BaseViewModel
    {
        public bool flag { get; set; }
        private string _Id;
        public string Id { get => _Id; set { _Id = value; OnPropertyChanged(); } }
        private string _Username;
        public string Username { get => _Username; set { _Username = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        private string _PasswordVerify;
        public string PasswordVerify { get => _PasswordVerify; set { _PasswordVerify = value; OnPropertyChanged(); } }

        public ICommand CloseCommand { get; set; }
        public ICommand SignUpCommand { get; set; }
        public LogupViewModel()
        {
            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Close(p); });
            SignUpCommand = new RelayCommand<Window>((p) => { return true; }, 
                (p) => 
                {
                    var a = DataProvider.Ins.DB.STAFFs.Where(x => x.STAFF_ID == Id);
                    if (a.Count() == 0)
                    {
                        MessageBox.Show("Mã nhiên viên không tồn tại, vui lòng nhập lại!", "Notifications", MessageBoxButton.OK, MessageBoxImage.Information);
                        flag = false;
                    }
                    else
                    if (Password != PasswordVerify)
                    {
                        MessageBox.Show("Mật khẩu xác thực không giống nhau, nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        flag = false;
                    }
                    else
                    if(DataProvider.Ins.DB.USERS.Where(x=> x.US_USERNAME == Username).Count() != 0)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại, vui lòng nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        flag = false;
                    }
                    else
                    {
                        string passEncode = MD5Hash(Base64Encode(Password));
                        int temp = DataProvider.Ins.DB.USERS.Count();
                        string id = "US" + (++temp).ToString();

                        int t = 1;
                        if (a.First().POSITION == "Nhân viên")
                            t = 2;

                        var newUser = new USER() { US_ID = id, US_USERNAME = Username, US_PASSWORD = passEncode, STAFF_ID = a.First().STAFF_ID, DISPLAYNAME = a.First().FULL_NAME, ROLE_ID = t };
                        DataProvider.Ins.DB.USERS.Add(newUser);
                        DataProvider.Ins.DB.SaveChanges();

                        MessageBox.Show("Success!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);

                        Close(p);
                    }
                });
        }
        void Close(Window p)
        {
            flag = true;
            p.Close();
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
