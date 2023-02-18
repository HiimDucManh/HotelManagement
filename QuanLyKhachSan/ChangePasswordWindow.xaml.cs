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
    /// Interaction logic for ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        public string ID;
        public ChangePasswordWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var t = MD5Hash(Base64Encode(oldPassword.Text));
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            var a = DataProvider.Ins.DB.USERS.Where(x => x.US_ID == ID);
            if (newPassword.Text == "" || newPassword == null || passwordVerify.Text == "" || passwordVerify == null)
                MessageBox.Show("Phải nhập đầy đủ thông tin", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            if (a.First().US_PASSWORD != t)
            {
                MessageBox.Show("Mật khẩu không chính xác, nhập lại.", "Eror", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            if (newPassword.Text != passwordVerify.Text)
                MessageBox.Show("Mật khẩu mới không trùng khớp, nhập lai!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            
            else
            {
                var newPass = MD5Hash(Base64Encode(newPassword.Text));
                a.First().US_PASSWORD = newPass;
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                DataProvider.Ins.DB.SaveChanges();
                this.Close();
            }
        }

        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
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
