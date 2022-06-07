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
            
            TableAbonents.ItemsSource = $"{{d:{data} ItemCount={Convert.ToString(data.Count)}}}";
            
            //TableAbonents.ItemsSource = data;
            

        }
    }
}
