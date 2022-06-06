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
                frames.UserWindow user_window = new frames.UserWindow(TextBoxFIO.Text);
                user_window.Show();
            }
        }

        private void ButtonAdminClick(object sender, RoutedEventArgs e)
        {
            frames.AuthorizationWindow authorizationWindow = new frames.AuthorizationWindow();
            authorizationWindow.Show();
        }
    }
}
