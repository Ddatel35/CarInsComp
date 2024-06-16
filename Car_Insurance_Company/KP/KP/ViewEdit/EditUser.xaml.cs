using KP.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

namespace KP.ViewEdit
{
    /// <summary>
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        private User _user = new User();

        public EditUser(User selectedUser)
        {
            InitializeComponent();
            _user = selectedUser;
            DataContext = _user;
            Post.ItemsSource = AppData.db.Roles.ToList();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_user.Login))
                erros.AppendLine("Укажите Логин");
            if (string.IsNullOrWhiteSpace(_user.Password))
                erros.AppendLine("Укажите Пароль");
            if (Post.SelectedValue == null)
                erros.AppendLine("Укажите Должность");
            try
            {
                AppData.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
