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
using KP.Model;
using KP.View;

namespace KP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static class Globals
        {
            public static int UserRole;

            public static string Login;
            public static User userinfo { get; set; }
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.User.FirstOrDefault(u => u.Login == Txb_Login.Text);
            if (CurrentUser != null)
            {
                Globals.UserRole = CurrentUser.Role_ID;
                Globals.userinfo = CurrentUser;
                Txb_Pass.IsEnabled = true;
                Btn_Login.Visibility = Visibility.Hidden;
                Btn_Pass.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
                Txb_Login.Clear();
            }
        }

        private void Btn_Pass_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser1 = AppData.db.User.FirstOrDefault(u => u.Password == Txb_Pass.Password);
            if (CurrentUser1 != null)
            {
                if (MainWindow.Globals.UserRole == 1)
                {
                    MessageBox.Show("Вы вошли под администратором!");
                    WindowContract windowGlav = new WindowContract();
                    windowGlav.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Вы вошли под пользователем!");
                    WindowContract windowGlav = new WindowContract();
                    windowGlav.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Пароль не верен!");
                Txb_Pass.Clear();
            }
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Txb_Login.Clear();
            Txb_Pass.IsEnabled = false;
            Txb_Pass.Clear();
            Btn_Login.Visibility = Visibility.Visible;
            Btn_Pass.Visibility = Visibility.Hidden;
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
