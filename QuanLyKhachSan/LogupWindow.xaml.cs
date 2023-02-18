using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyKhachSan
{
    /// <summary>
    /// Interaction logic for LogupWindow.xaml
    /// </summary>
    public partial class LogupWindow : Window
    {
        public bool flag;
        public LogupWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            flag = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.STAFFs.Where(x => x.STAFF_ID == id.Text);
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (username == null || username.Text == "" || id.Text == "" || id == null || password.Password == "" || password == null || passwordVerify.Password == "" || passwordVerify == null)
                MessageBox.Show("Phải nhập đầy đủ thông tin", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            if (a.Count() == 0)
            {
                MessageBox.Show("Mã nhiên viên không tồn tại, vui lòng nhập lại!", "Notifications", MessageBoxButton.OK, MessageBoxImage.Information);
                flag = false;
            }
            else
            if (password.Password != passwordVerify.Password)
            {
                MessageBox.Show("Mật khẩu xác thực không giống nhau, nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                flag = false;
            }
            else
            if (DataProvider.Ins.DB.USERS.Where(x => x.US_USERNAME == username.Text).Count() != 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại, vui lòng nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                flag = false;
            }
            else
                if(!regexItem.IsMatch(username.Text))
                MessageBox.Show("Không thể chứa các ký tự đặc biệt!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                string passEncode = MD5Hash(Base64Encode(password.Password));
                int temp = DataProvider.Ins.DB.USERS.Count();
                string id = "US" + (++temp).ToString();

                int t = 1;
                if (a.First().POSITION == "Nhân viên")
                    t = 2;

                var newUser = new USER() { US_ID = id, US_USERNAME = username.Text, US_PASSWORD = passEncode, STAFF_ID = a.First().STAFF_ID, DISPLAYNAME = a.First().FULL_NAME, ROLE_ID = t };
                DataProvider.Ins.DB.USERS.Add(newUser);
                DataProvider.Ins.DB.SaveChanges();

                MessageBox.Show("Success!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);

                flag = true;
                this.Close();
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
