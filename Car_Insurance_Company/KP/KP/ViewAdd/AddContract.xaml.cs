using KP.Model;
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
using System.Windows.Shapes;

namespace KP.ViewAdd
{
    /// <summary>
    /// Логика взаимодействия для AddContract.xaml
    /// </summary>
    public partial class AddContract : Window
    {
        private ContractAndClient contract = new ContractAndClient();
        public AddContract()
        {
            InitializeComponent();
            DataContext = contract;
        }

        private void Btn_Add(object sender, RoutedEventArgs e)
        {
            StringBuilder Errors = new StringBuilder();

            if (FirtsName.Text == "")
                Errors.AppendLine("Введите фамилию");
            if (Name.Text == "")
                Errors.AppendLine("Введите имя");
            if (MiddleName.Text == "")
                Errors.AppendLine("Введите очество");
            if (Number.Text == "")
                Errors.AppendLine("Введите номер телефона");
            if (Strahov.SelectedValue == null)
                Errors.AppendLine("Выберите тип страховки");
            if(Price.Text == "")
                Errors.AppendLine("Введите платёж");
            if(GosNumber.Text == "")
                Errors.AppendLine("Введите гос. номер");
            if (NameAuto.Text == "")
                Errors.AppendLine("Введите марку авто");
            if (DateEnd1.SelectedDate == null)
                Errors.AppendLine("Введите дату заключения");
            if (Date.SelectedDate == null)
                Errors.AppendLine("Введите дату конца страховки");

            if (Errors.Length > 0)
            {
                MessageBox.Show(Errors.ToString());
                return;
            }

            contract.FirstName = FirtsName.Text;
            contract.Name = Name.Text;
            contract.MiddleName = MiddleName.Text;
            contract.Number = Number.Text;
            contract.Insurance = Strahov.Text;
            contract.DateFirts = DateEnd1.DisplayDate;
            contract.IncurancePayment = Price.Text;
            contract.Tern = Date.DisplayDate;
            contract.GosNumber = GosNumber.Text;
            contract.NameCar = NameAuto.Text;

            StrahovanieDBEntities.GetContext().ContractAndClient.Add(contract);
            StrahovanieDBEntities.GetContext().SaveChanges();
            MessageBox.Show("Контракт был добавлен в базу!");
            this.Close();
        }

        private void Btn_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
