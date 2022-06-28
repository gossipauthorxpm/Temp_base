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

namespace temp_base
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

        private void ButtonFIOClick(object sender, RoutedEventArgs e)
        {
            //Ввод ФИО и получение данных и БД
            if (!TextBoxFIO.Text.Equals(""))
            {
                //Проверка на наличии имени в БД
                data.Database database = new data.Database();
                List<objects.Abonent> abonents = database.SelectAllData();
                objects.Abonent abonent = CheckNameInDatabase(TextBoxFIO.Text, abonents);
                if (abonent != null)
                {
                    frames.UserWindow user_window = new frames.UserWindow(TextBoxFIO.Text, abonent);
                    user_window.Show();
                }
                else
                {
                    MessageBox.Show("Ошибка! Данного пользователя нет в базе данных!\nПроверьте правильность ввода!.", "Ошибка");
                }
            }
        }

        private void ButtonAdminClick(object sender, RoutedEventArgs e)
        {
            frames.AuthorizationWindow authorizationWindow = new frames.AuthorizationWindow();
            authorizationWindow.Show();
        }

        private objects.Abonent CheckNameInDatabase(string fio_user, List<objects.Abonent> abonents)
        {
            foreach (objects.Abonent item in abonents)
            {
                if (item.GetName.Equals(fio_user))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
