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

namespace temp_base.frames
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        //Кнопка авторизоваться в панель админа
        private void AuthorizationButtonClick(object sender, RoutedEventArgs e)
        {
            if(!LoginField.Text.Equals("") && !PasswordField.Text.Equals(""))
            {
                if(LoginField.Text.Equals(data.StaticData.AdminLogin) && PasswordField.Text.Equals(data.StaticData.AdminPassword))
                {
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                    //Закрываем окно авторизации
                    Close();
                }
                
            }
        }
    }
}
