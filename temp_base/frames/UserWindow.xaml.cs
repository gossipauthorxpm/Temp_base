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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        
        private objects.Abonent abonent;
        

        public UserWindow(string fio_user, objects.Abonent abonent)
        {
            InitializeComponent();
            // Инициализация всех элементов окна пользователя из БД по имени пользователя
            USER_FIO_LABEL.Content = fio_user;
            this.abonent = abonent;
            CreateFormLabels();
            
        }
        private void CreateFormLabels()
        {
            number_poligon.Text = abonent.GetId;
            date_last_transaction.Text = abonent.GetDate;
            amount_sum.Text = abonent.GetSumAmouth;

        }
        
    }

}
