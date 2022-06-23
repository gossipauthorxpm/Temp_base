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
    /// Логика взаимодействия для TableAbonentsWindow.xaml
    /// </summary>
    public partial class TableAbonentsWindow : Window
    {
        public TableAbonentsWindow()
        {
            InitializeComponent();
            data.Database database = new data.Database();
            List<objects.Abonent> data = database.SelectAllData();
            // Заполнение таблицы данными из SQL запроса
            foreach(objects.Abonent obj in data)
            {
                AbonentsTable.Items.Add($"ID - {obj.GetId}. ФИО - {obj.GetName}. АДРЕС - {obj.GetAdress}. НОМЕР РЭП - {obj.GetREP}. ДАТА ПОСЛЕДНЕГО ПЛАТЕЖА - {obj.GetDate}. НОМЕР СЧЕТА - {obj.GetMoneyFold}. СУММА ДОЛГА{obj.GetSumAmouth}");
            }

        }
        // Вставка в буфер обмена при нажатии на объект строки listbox
        private void AbonentsTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = AbonentsTable.SelectedItem;
            Clipboard.SetText(item.ToString());
        }
    }
}
