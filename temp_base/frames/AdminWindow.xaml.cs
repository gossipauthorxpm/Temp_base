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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ButtonUpdateDataAdmin(object sender, RoutedEventArgs e)
        {
            frames.TableAbonentsWindow window = new frames.TableAbonentsWindow();
            window.Show();
        }

        private void CheckInfoOfUserButtonClick(object sender, RoutedEventArgs e)
        {
            data.Database database = new data.Database();
            List<objects.Abonent> abonents = database.SelectAllData();

            foreach(objects.Abonent item in abonents)
            {
                if (name_abonent.Text.Equals(item.GetName))
                {
                    return_data_abonent.Content = $"ID - {item.GetId}. Дата последнего платежа - {item.GetDate}\nСумма долга - {item.GetSumAmouth}";
                    return;
                }
            }
            MessageBox.Show("Ошибка! Данного пользователя нет в БД!", "Ошибка!");
        }
    }
}
