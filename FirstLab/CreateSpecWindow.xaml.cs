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

namespace FirstLab
{
    /// <summary>
    /// Логика взаимодействия для CreateSpecWindow.xaml
    /// </summary>
    public partial class CreateSpecWindow : Window
    {
        private FirstPage firstPage = MainWindow.pages[0] as FirstPage;
        public CreateSpecWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text != string.Empty)
            {
                firstPage.GetAdapter().InsertSpecName(NameTextBox.Text);
                firstPage.GetDataGrid().ItemsSource = firstPage.GetAdapter().GetData();
            }
            else
            {
                MessageBox.Show("Заполните поле \"Название специализации\"!", "Ошибка");
            }
        }
    }
}
