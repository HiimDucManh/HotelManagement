using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyKhachSan
{
    /// <summary>
    /// Interaction logic for PageRoom.xaml
    /// </summary>
    public partial class PageRoom : Page
    {
        
        public PageRoom()
        {
            InitializeComponent();
        }
        public void GETVALUE(List<string> value)
        {
            
            switch (value[0])
            {
                case "101":
                    cus101.Content = value[1];
                    timearrival101.Text = value[2];
                    timeleft101.Text = value[3];
                    break;
                case "102":
                    cus102.Content = value[1];
                    timearrival102.Text = value[2];
                    timeleft102.Text = value[3];
                    break;
                case "103":
                    cus103.Content = value[1];
                    timearrival103.Text = value[2];
                    timeleft103.Text = value[3];
                    break;
                case "104":
                    cus104.Content = value[1];
                    timearrival104.Text = value[2];
                    timeleft104.Text = value[3];
                    break;
                case "105":
                    cus105.Content = value[1];
                    timearrival105.Text = value[2];
                    timeleft105.Text = value[3];
                    break;
                case "201":
                    cus201.Content = value[1];
                    timearrival201.Text = value[2];
                    timeleft201.Text = value[3];
                    break;
                case "202":
                    cus202.Content = value[1];
                    timearrival202.Text = value[2];
                    timeleft202.Text = value[3];
                    break;
                case "203":
                    cus203.Content = value[1];
                    timearrival203.Text = value[2];
                    timeleft203.Text = value[3];
                    break;
                case "204":
                    cus204.Content = value[1];
                    timearrival204.Text = value[2];
                    timeleft204.Text = value[3];
                    break;
                case "205":
                    cus205.Content = value[1];
                    timearrival205.Text = value[2];
                    timeleft205.Text = value[3];
                    break;
                case "301":
                    cus301.Content = value[1];
                    timearrival301.Text = value[2];
                    timeleft301.Text = value[3];
                    break;
                case "302":
                    cus302.Content = value[1];
                    timearrival302.Text = value[2];
                    timeleft302.Text = value[3];
                    break;
                case "303":
                    cus303.Content = value[1];
                    timearrival303.Text = value[2];
                    timeleft303.Text = value[3];
                    break;
                case "304":
                    cus304.Content = value[1];
                    timearrival304.Text = value[2];
                    timeleft304.Text = value[3];
                    break;
                case "305":
                    cus305.Content = value[1];
                    timearrival305.Text = value[2];
                    timeleft305.Text = value[3];
                    break;
                case "401":
                    cus401.Content = value[1];
                    timearrival401.Text = value[2];
                    timeleft401.Text = value[3];
                    break;
                case "402":
                    cus402.Content = value[1];
                    timearrival402.Text = value[2];
                    timeleft402.Text = value[3];
                    break;
                case "403":
                    cus403.Content = value[1];
                    timearrival403.Text = value[2];
                    timeleft403.Text = value[3];
                    break;
                case "404":
                    cus404.Content = value[1];
                    timearrival404.Text = value[2];
                    timeleft404.Text = value[3];
                    break;
                case "405":
                    cus405.Content = value[1];
                    timearrival405.Text = value[2];
                    timeleft405.Text = value[3];
                    break;
            }
        }
        private void Room101_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "101");
            if (a.Count() > 0)
            {
                cus101.Content = a.First().CUS_NAME;
                timearrival101.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft101.Text = a.First().DAY_LEFT.ToString();
                Book101.IsEnabled = false;
                pay101.IsEnabled = true;
                front101.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus101.Content = null;
                timearrival101.Text = null;
                timeleft101.Text = null;
                Book101.IsEnabled = true;
                pay101.IsEnabled = false;
                front101.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room102_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "102");
            if (a.Count() > 0)
            {
                cus102.Content = a.First().CUS_NAME;
                timearrival102.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft102.Text = a.First().DAY_LEFT.ToString();
                Book102.IsEnabled = false;
                pay102.IsEnabled = true;
                front102.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus102.Content = null;
                timearrival102.Text = null;
                timeleft102.Text = null;
                Book102.IsEnabled = true;
                pay102.IsEnabled = false;
                front102.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room103_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "103");
            if (a.Count() > 0)
            {
                cus103.Content = a.First().CUS_NAME;
                timearrival103.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft103.Text = a.First().DAY_LEFT.ToString();
                Book103.IsEnabled = false;
                pay103.IsEnabled = true;
                front103.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus103.Content = null;
                timearrival103.Text = null;
                timeleft103.Text = null;
                Book103.IsEnabled = true;
                pay103.IsEnabled = false;
                front103.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room104_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "104");
            if (a.Count() > 0)
            {
                cus104.Content = a.First().CUS_NAME;
                timearrival104.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft104.Text = a.First().DAY_LEFT.ToString();
                Book104.IsEnabled = false;
                pay104.IsEnabled = true;
                front104.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus104.Content = null;
                timearrival104.Text = null;
                timeleft104.Text = null;
                Book104.IsEnabled = true;
                pay104.IsEnabled = false;
                front104.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room105_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "105");
            if (a.Count() > 0)
            {
                cus105.Content = a.First().CUS_NAME;
                timearrival105.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft105.Text = a.First().DAY_LEFT.ToString();
                Book105.IsEnabled = false;
                pay105.IsEnabled = true;
                front105.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus105.Content = null;
                timearrival105.Text = null;
                timeleft105.Text = null;
                Book105.IsEnabled = true;
                pay105.IsEnabled = false;
                front105.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room201_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "201");
            if (a.Count() > 0)
            {
                cus201.Content = a.First().CUS_NAME;
                timearrival201.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft201.Text = a.First().DAY_LEFT.ToString();
                Book201.IsEnabled = false;
                pay201.IsEnabled = true;
                front201.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus201.Content = null;
                timearrival201.Text = null;
                timeleft201.Text = null;
                Book201.IsEnabled = true;
                pay201.IsEnabled = false;
                front201.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room202_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "202");
            if (a.Count() > 0)
            {
                cus202.Content = a.First().CUS_NAME;
                timearrival202.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft202.Text = a.First().DAY_LEFT.ToString();
                Book202.IsEnabled = false;
                pay202.IsEnabled = true;
                front202.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus202.Content = null;
                timearrival202.Text = null;
                timeleft202.Text = null;
                Book202.IsEnabled = true;
                pay202.IsEnabled = false;
                front202.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room203_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "203");
            if (a.Count() > 0)
            {
                cus203.Content = a.First().CUS_NAME;
                timearrival203.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft203.Text = a.First().DAY_LEFT.ToString();
                Book203.IsEnabled = false;
                pay203.IsEnabled = true;
                front203.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus203.Content = null;
                timearrival203.Text = null;
                timeleft203.Text = null;
                Book203.IsEnabled = true;
                pay203.IsEnabled = false;
                front203.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room204_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "204");
            if (a.Count() > 0)
            {
                cus204.Content = a.First().CUS_NAME;
                timearrival204.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft204.Text = a.First().DAY_LEFT.ToString();
                Book204.IsEnabled = false;
                pay204.IsEnabled = true;
                front204.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus204.Content = null;
                timearrival204.Text = null;
                timeleft204.Text = null;
                Book204.IsEnabled = true;
                pay204.IsEnabled = false;
                front204.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room205_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "205");
            if (a.Count() > 0)
            {
                cus205.Content = a.First().CUS_NAME;
                timearrival205.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft205.Text = a.First().DAY_LEFT.ToString();
                Book205.IsEnabled = false;
                pay205.IsEnabled = true;
                front205.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus205.Content = null;
                timearrival205.Text = null;
                timeleft205.Text = null;
                Book205.IsEnabled = true;
                pay205.IsEnabled = false;
                front205.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room301_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "301");
            if (a.Count() > 0)
            {
                cus301.Content = a.First().CUS_NAME;
                timearrival301.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft301.Text = a.First().DAY_LEFT.ToString();
                Book301.IsEnabled = false;
                pay301.IsEnabled = true;
                front301.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus301.Content = null;
                timearrival301.Text = null;
                timeleft301.Text = null;
                Book301.IsEnabled = true;
                pay301.IsEnabled = false;
                front301.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room302_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "302");
            if (a.Count() > 0)
            {
                cus302.Content = a.First().CUS_NAME;
                timearrival302.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft302.Text = a.First().DAY_LEFT.ToString();
                Book302.IsEnabled = false;
                pay302.IsEnabled = true;
                front302.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus302.Content = null;
                timearrival302.Text = null;
                timeleft302.Text = null;
                Book302.IsEnabled = true;
                pay301.IsEnabled = false;
                front302.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room303_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "303");
            if (a.Count() > 0)
            {
                cus303.Content = a.First().CUS_NAME;
                timearrival303.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft303.Text = a.First().DAY_LEFT.ToString();
                Book303.IsEnabled = false;
                pay303.IsEnabled = true;
                front303.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus303.Content = null;
                timearrival303.Text = null;
                timeleft303.Text = null;
                Book303.IsEnabled = true;
                pay303.IsEnabled = false;
                front303.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room304_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "304");
            if (a.Count() > 0)
            {
                cus304.Content = a.First().CUS_NAME;
                timearrival304.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft304.Text = a.First().DAY_LEFT.ToString();
                Book304.IsEnabled = false;
                pay304.IsEnabled = true;
                front304.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus304.Content = null;
                timearrival304.Text = null;
                timeleft304.Text = null;
                Book304.IsEnabled = true;
                pay304.IsEnabled = false;
                front304.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room305_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "305");
            if (a.Count() > 0)
            {
                cus305.Content = a.First().CUS_NAME;
                timearrival305.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft305.Text = a.First().DAY_LEFT.ToString();
                Book305.IsEnabled = false;
                pay305.IsEnabled = true;
                front305.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus305.Content = null;
                timearrival305.Text = null;
                timeleft305.Text = null;
                Book305.IsEnabled = true;
                pay305.IsEnabled = false;
                front305.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room401_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "401");
            if (a.Count() > 0)
            {
                cus401.Content = a.First().CUS_NAME;
                timearrival401.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft401.Text = a.First().DAY_LEFT.ToString();
                Book401.IsEnabled = false;
                pay401.IsEnabled = true;
                front401.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus401.Content = null ;
                timearrival401.Text = null;
                timeleft401.Text = null;
                Book401.IsEnabled = true;
                pay401.IsEnabled = false;
                front401.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room402_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "402");
            if (a.Count() > 0)
            {
                cus402.Content = a.First().CUS_NAME;
                timearrival402.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft402.Text = a.First().DAY_LEFT.ToString();
                Book402.IsEnabled = false;
                pay402.IsEnabled = true;
                front402.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus402.Content = null;
                timearrival402.Text = null;
                timeleft402.Text = null;
                Book402.IsEnabled = true;
                pay402.IsEnabled = false;
                front401.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room403_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "403");
            if (a.Count() > 0)
            {
                cus403.Content = a.First().CUS_NAME;
                timearrival403.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft403.Text = a.First().DAY_LEFT.ToString();
                Book403.IsEnabled = false;
                pay403.IsEnabled = true;
                front403.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus403.Content = null;
                timearrival403.Text = null;
                timeleft403.Text = null;
                Book403.IsEnabled = true;
                pay403.IsEnabled = false;
                front404.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room404_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "404");
            if (a.Count() > 0)
            {
                cus404.Content = a.First().CUS_NAME;
                timearrival404.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft404.Text = a.First().DAY_LEFT.ToString();
                Book404.IsEnabled = false;
                pay404.IsEnabled = true;
                front404.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus404.Content = null;
                timearrival404.Text = null;
                timeleft404.Text = null;
                Book404.IsEnabled = true;
                pay404.IsEnabled = false;
                front404.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Room405_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "405");
            if (a.Count() > 0)
            {
                cus405.Content = a.First().CUS_NAME;
                timearrival405.Text = a.First().DAY_ARRIVAL.ToString();
                timeleft405.Text = a.First().DAY_LEFT.ToString();
                Book405.IsEnabled = false;
                pay405.IsEnabled = true;
                front405.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                cus405.Content = null;
                timearrival405.Text = null;
                timeleft405.Text = null;
                Book405.IsEnabled = true;
                pay405.IsEnabled = false;
                front405.Background = new SolidColorBrush(Colors.WhiteSmoke);
            }
        }
        private void Button_Click_101(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "101";
                roomBookWindow.ShowDialog();
                Room101_Loaded(sender, e);
        }
        private void Button_Click_102(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "102";
                roomBookWindow.ShowDialog();
            Room102_Loaded(sender, e);
        }
        private void Button_Click_103(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "103";
                roomBookWindow.ShowDialog();
            Room103_Loaded(sender, e);
        }
        private void Button_Click_104(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "104";
                roomBookWindow.ShowDialog();
                Room104_Loaded(sender, e);
        }
        private void Button_Click_105(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "105";
                roomBookWindow.ShowDialog();
            Room105_Loaded(sender, e);
        }
        private void Button_Click_201(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "201";
                roomBookWindow.ShowDialog();
            Room201_Loaded(sender, e);
        }
        private void Button_Click_202(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "202";
                roomBookWindow.ShowDialog();
            Room202_Loaded(sender, e);
        }
        private void Button_Click_203(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "203";
                roomBookWindow.ShowDialog();
            Room203_Loaded(sender, e);
        }
        private void Button_Click_204(object sender, RoutedEventArgs e)
        {

                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "204";
                roomBookWindow.ShowDialog();
            Room204_Loaded(sender, e);
        }
        private void Button_Click_205(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "205";
                roomBookWindow.ShowDialog();
            Room205_Loaded(sender, e);
        }
        private void Button_Click_301(object sender, RoutedEventArgs e)
        {

                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "301";
                roomBookWindow.ShowDialog();
            Room301_Loaded(sender, e);
        }
        private void Button_Click_302(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "302";
                roomBookWindow.ShowDialog();
            Room302_Loaded(sender, e);
        }
        private void Button_Click_303(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "303";
                roomBookWindow.ShowDialog();
            Room303_Loaded(sender, e);
        }
        private void Button_Click_304(object sender, RoutedEventArgs e)
        {

                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "304";
                roomBookWindow.ShowDialog();
            Room304_Loaded(sender, e);
        }
        private void Button_Click_305(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "305";
                roomBookWindow.ShowDialog();
            Room305_Loaded(sender, e);
        }
        private void Button_Click_401(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "401";
                roomBookWindow.ShowDialog();
            Room401_Loaded(sender, e);
        }
        private void Button_Click_402(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "402";
                roomBookWindow.ShowDialog();
            Room402_Loaded(sender, e);
        }
        private void Button_Click_403(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "403";
                roomBookWindow.ShowDialog();
            Room403_Loaded(sender, e);
        }
        private void Button_Click_404(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "404";
                roomBookWindow.ShowDialog();
            Room404_Loaded(sender, e);
        }
        private void Button_Click_405(object sender, RoutedEventArgs e)
        {
                RoomBookWindow roomBookWindow = new RoomBookWindow();
                roomBookWindow.temp = "405";
                roomBookWindow.ShowDialog();
            Room405_Loaded(sender, e);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RoomBookWindow roomBookWindow = new RoomBookWindow();
            roomBookWindow.mydata = new RoomBookWindow.GETDATA(GETVALUE);
            roomBookWindow.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "101");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "101";
                a.ShowDialog();

                Room101_Loaded(sender, e);
                //var a = new PrintBillWindow();
                //a.ID = "101";
                //a.ShowDialog();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "102");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "102";
                a.ShowDialog();
                Room102_Loaded(sender, e);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "103");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "103";
                a.ShowDialog();
                Room103_Loaded(sender, e);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "104");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "104";
                a.ShowDialog();
                Room104_Loaded(sender, e);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "105");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "105";
                a.ShowDialog();
                Room105_Loaded(sender, e);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "201");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "201";
                a.ShowDialog();
                Room201_Loaded(sender, e);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "202");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "202";
                a.ShowDialog();
                Room202_Loaded(sender, e);
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "203");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "203";
                a.ShowDialog();
                Room203_Loaded(sender, e);
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "204");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "204";
                a.ShowDialog();
                Room204_Loaded(sender, e);
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "205");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "205";
                a.ShowDialog();
                Room205_Loaded(sender, e);
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "301");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "301";
                a.ShowDialog();
                Room301_Loaded(sender, e);
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "302");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "302";
                a.ShowDialog();
                Room302_Loaded(sender, e);
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "303");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "303";
                a.ShowDialog();
                Room303_Loaded(sender, e);
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "304");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "304";
                a.ShowDialog();
                Room304_Loaded(sender, e);
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "305");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "305";
                a.ShowDialog();
                Room305_Loaded(sender, e);
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "401");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "401";
                a.ShowDialog();
                Room401_Loaded(sender, e);
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "402");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "402";
                a.ShowDialog();
                Room402_Loaded(sender, e);
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "403");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "403";
                a.ShowDialog();
                Room403_Loaded(sender, e);
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "404");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "404";
                a.ShowDialog();
                Room404_Loaded(sender, e);
            }
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            var b = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == "405");
            if (b.First().DAY_ARRIVAL == null || b.First().DAY_LEFT == null || b.First().DAY_BOOK == null)
                MessageBox.Show("Vui lòng nhập đủ ngày tháng!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                var a = new BillWindow();
                a.Temp = "405";
                a.ShowDialog();
                Room405_Loaded(sender, e);
            }
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "101";
            editBooking.ShowDialog();
            Room101_Loaded(sender, e);
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "102";
            editBooking.ShowDialog();
            Room102_Loaded(sender, e);

        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "103";
            editBooking.ShowDialog();
            Room103_Loaded(sender, e);
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "104";
            editBooking.ShowDialog();
            Room104_Loaded(sender, e);
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "105";
            editBooking.ShowDialog();
            Room105_Loaded(sender, e);
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "201";
            editBooking.ShowDialog();
            Room201_Loaded(sender, e);
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "202";
            editBooking.ShowDialog();
            Room202_Loaded(sender, e);
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "203";
            editBooking.ShowDialog();
            Room203_Loaded(sender, e);
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "204";
            editBooking.ShowDialog();
            Room204_Loaded(sender, e);
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "205";
            editBooking.ShowDialog();
            Room205_Loaded(sender, e);
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "301";
            editBooking.ShowDialog();
            Room301_Loaded(sender, e);
        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "302";
            editBooking.ShowDialog();
            Room302_Loaded(sender, e);
        }

        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "303";
            editBooking.ShowDialog();
            Room303_Loaded(sender, e);
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "304";
            editBooking.ShowDialog();
            Room304_Loaded(sender, e);
        }

        private void Button_Click_35(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "305";
            editBooking.ShowDialog();
            Room305_Loaded(sender, e);
        }

        private void Button_Click_36(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "401";
            editBooking.ShowDialog();
            Room401_Loaded(sender, e);
        }

        private void Button_Click_37(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "402";
            editBooking.ShowDialog();
            Room402_Loaded(sender, e);
        }

        private void Button_Click_38(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "403";
            editBooking.ShowDialog();
            Room403_Loaded(sender, e);
        }

        private void Button_Click_39(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "404";
            editBooking.ShowDialog();
            Room404_Loaded(sender, e);
        }

        private void Button_Click_40(object sender, RoutedEventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.Temp = "405";
            editBooking.ShowDialog();
            Room405_Loaded(sender, e);
        }

        private void Button_Click_41(object sender, RoutedEventArgs e)
        {
            if (Book101.IsEnabled == false)
                Room101.Visibility = Visibility.Hidden;
            else Room101.Visibility = Visibility.Visible;
            if (Book102.IsEnabled == false)
                Room102.Visibility = Visibility.Hidden;
            else Room102.Visibility = Visibility.Visible;
            if (Book103.IsEnabled == false)
                Room103.Visibility = Visibility.Hidden;
            else Room103.Visibility = Visibility.Visible;
            if (Book104.IsEnabled == false)
                Room104.Visibility = Visibility.Hidden;
            else Room104.Visibility = Visibility.Visible;
            if (Book105.IsEnabled == false)
                Room105.Visibility = Visibility.Hidden;
            else Room105.Visibility = Visibility.Visible;
            if (Book201.IsEnabled == false)
                Room201.Visibility = Visibility.Hidden;
            else Room201.Visibility = Visibility.Visible;
            if (Book202.IsEnabled == false)
                Room202.Visibility = Visibility.Hidden;
            else Room202.Visibility = Visibility.Visible;
            if (Book203.IsEnabled == false)
                Room203.Visibility = Visibility.Hidden;
            else Room203.Visibility = Visibility.Visible;
            if (Book204.IsEnabled == false)
                Room204.Visibility = Visibility.Hidden;
            else Room204.Visibility = Visibility.Visible;
            if (Book205.IsEnabled == false)
                Room205.Visibility = Visibility.Hidden;
            else Room205.Visibility = Visibility.Visible;
            if (Book301.IsEnabled == false)
                Room301.Visibility = Visibility.Hidden;
            else Room301.Visibility = Visibility.Visible;
            if (Book302.IsEnabled == false)
                Room302.Visibility = Visibility.Hidden;
            else Room302.Visibility = Visibility.Visible;
            if (Book303.IsEnabled == false)
                Room303.Visibility = Visibility.Hidden;
            else Room303.Visibility = Visibility.Visible;
            if (Book304.IsEnabled == false)
                Room304.Visibility = Visibility.Hidden;
            else Room304.Visibility = Visibility.Visible;
            if (Book305.IsEnabled == false)
                Room305.Visibility = Visibility.Hidden;
            else Room305.Visibility = Visibility.Visible;
            if (Book401.IsEnabled == false)
                Room401.Visibility = Visibility.Hidden;
            else Room401.Visibility = Visibility.Visible;
            if (Book402.IsEnabled == false)
                Room402.Visibility = Visibility.Hidden;
            else Room402.Visibility = Visibility.Visible;
            if (Book403.IsEnabled == false)
                Room403.Visibility = Visibility.Hidden;
            else Room403.Visibility = Visibility.Visible;
            if (Book404.IsEnabled == false)
                Room404.Visibility = Visibility.Hidden;
            else Room404.Visibility = Visibility.Visible;
            if (Book405.IsEnabled == false)
                Room405.Visibility = Visibility.Hidden;
            else Room405.Visibility = Visibility.Visible;
        }

        private void Button_Click_42(object sender, RoutedEventArgs e)
        {
            Room101.Visibility = Visibility.Visible;
            Room102.Visibility = Visibility.Visible;
            Room103.Visibility = Visibility.Visible;
            Room104.Visibility = Visibility.Visible;
            Room105.Visibility = Visibility.Visible;
            Room201.Visibility = Visibility.Visible;
            Room202.Visibility = Visibility.Visible;
            Room203.Visibility = Visibility.Visible;
            Room204.Visibility = Visibility.Visible;
            Room205.Visibility = Visibility.Visible;
            Room301.Visibility = Visibility.Visible;
            Room302.Visibility = Visibility.Visible;
            Room303.Visibility = Visibility.Visible;
            Room304.Visibility = Visibility.Visible;
            Room305.Visibility = Visibility.Visible;
            Room401.Visibility = Visibility.Visible;
            Room402.Visibility = Visibility.Visible;
            Room403.Visibility = Visibility.Visible;
            Room404.Visibility = Visibility.Visible;
            Room405.Visibility = Visibility.Visible;
        }

        private void Button_Click_43(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_44(object sender, RoutedEventArgs e)
        {
            if (Book101.IsEnabled == true)
                Room101.Visibility = Visibility.Hidden;
            else Room101.Visibility = Visibility.Visible;
            if (Book102.IsEnabled == true)
                Room102.Visibility = Visibility.Hidden;
            else Room102.Visibility = Visibility.Visible;
            if (Book103.IsEnabled == true)
                Room103.Visibility = Visibility.Hidden;
            else Room103.Visibility = Visibility.Visible;
            if (Book104.IsEnabled == true)
                Room104.Visibility = Visibility.Hidden;
            else Room104.Visibility = Visibility.Visible;
            if (Book105.IsEnabled == true)
                Room105.Visibility = Visibility.Hidden;
            else Room105.Visibility = Visibility.Visible;
            if (Book201.IsEnabled == true)
                Room201.Visibility = Visibility.Hidden;
            else Room201.Visibility = Visibility.Visible;
            if (Book202.IsEnabled == true)
                Room202.Visibility = Visibility.Hidden;
            else Room202.Visibility = Visibility.Visible;
            if (Book203.IsEnabled == true)
                Room203.Visibility = Visibility.Hidden;
            else Room203.Visibility = Visibility.Visible;
            if (Book204.IsEnabled == true)
                Room204.Visibility = Visibility.Hidden;
            else Room204.Visibility = Visibility.Visible;
            if (Book205.IsEnabled == true)
                Room205.Visibility = Visibility.Hidden;
            else Room205.Visibility = Visibility.Visible;
            if (Book301.IsEnabled == true)
                Room301.Visibility = Visibility.Hidden;
            else Room301.Visibility = Visibility.Visible;
            if (Book302.IsEnabled == true)
                Room302.Visibility = Visibility.Hidden;
            else Room302.Visibility = Visibility.Visible;
            if (Book303.IsEnabled == true)
                Room303.Visibility = Visibility.Hidden;
            else Room303.Visibility = Visibility.Visible;
            if (Book304.IsEnabled == true)
                Room304.Visibility = Visibility.Hidden;
            else Room304.Visibility = Visibility.Visible;
            if (Book305.IsEnabled == true)
                Room305.Visibility = Visibility.Hidden;
            else Room305.Visibility = Visibility.Visible;
            if (Book401.IsEnabled == true)
                Room401.Visibility = Visibility.Hidden;
            else Room401.Visibility = Visibility.Visible;
            if (Book402.IsEnabled == true)
                Room402.Visibility = Visibility.Hidden;
            else Room402.Visibility = Visibility.Visible;
            if (Book403.IsEnabled == true)
                Room403.Visibility = Visibility.Hidden;
            else Room403.Visibility = Visibility.Visible;
            if (Book404.IsEnabled == true)
                Room404.Visibility = Visibility.Hidden;
            else Room404.Visibility = Visibility.Visible;
            if (Book405.IsEnabled == true)
                Room405.Visibility = Visibility.Hidden;
            else Room405.Visibility = Visibility.Visible;
        }
    }
}
