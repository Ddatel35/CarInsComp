using KP.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace KP.ViewAdd
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
            Post.ItemsSource = AppData.db.Roles.ToList();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            StringBuilder Errors = new StringBuilder();

            if (Login.Text == "")
                Errors.AppendLine("Введите логин");
            if (Pass.Text == "")
                Errors.AppendLine("Введите пароль");
            if (Post.SelectedValue == null)
                Errors.AppendLine("Введите должность");

            if (Errors.Length > 0)
            {
                MessageBox.Show(Errors.ToString());
                return;
            }

            User user = new User();
            user.Login = Login.Text;
            user.Password = Pass.Text;
            user.Role_ID = Post.SelectedIndex + 1;
            AppData.db.User.Add(user);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь был добавлен в базу!");
            this.Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
