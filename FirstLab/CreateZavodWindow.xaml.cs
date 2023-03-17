using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для CreateZavodWindow.xaml
    /// </summary>
    public partial class CreateZavodWindow : Window
    {
        private SecondPage secondPage = MainWindow.pages[1] as SecondPage;
        public CreateZavodWindow()
        {
            InitializeComponent();
            SpecIDComboBox.ItemsSource = new FirstPage().GetAdapter().GetData();
            SpecIDComboBox.DisplayMemberPath = "name";
            SpecIDComboBox.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SpecIDComboBox.SelectedItem != null && NameTextBox.Text != string.Empty && IncomeTextBox.Text != string.Empty)
            {
                if (int.TryParse(IncomeTextBox.Text, out int income))
                {
                    secondPage.GetAdapter().InsertZavod(NameTextBox.Text, SpecIDComboBox.SelectedIndex + 1, income);
                    secondPage.GetDataGrid().ItemsSource = secondPage.GetAdapter().GetData();
                    MessageBox.Show("Завод успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Введите число в поле \"Прибыль завода\"!", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }

        }

    }
}