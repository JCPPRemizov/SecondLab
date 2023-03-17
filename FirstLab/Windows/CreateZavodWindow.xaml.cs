using SecondLab.DataSetTableAdapters;
using System.Windows;


namespace SecondLab.Windows
{
    /// <summary>
    /// Логика взаимодействия для CreateZavodWindow.xaml
    /// </summary>
    public partial class CreateZavodWindow : Window
    {
        private zavodTableAdapter zavodTableAdapter = new zavodTableAdapter();
        private specializationsTableAdapter specializationsTableAdapter = new specializationsTableAdapter();
        public MainWindow mainWindow;
        public CreateZavodWindow()
        {
            InitializeComponent();
            TypeOfZavodBox.ItemsSource = specializationsTableAdapter.GetData();
            TypeOfZavodBox.DisplayMemberPath = "name";
            TypeOfZavodBox.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetDataGrid();
        }
        private void SetDataGrid()
        {
            if (NameTextBox.Text != string.Empty && IncomeTextBox.Text != string.Empty && TypeOfZavodBox.SelectedItem != null)
            {
                if (int.TryParse(IncomeTextBox.Text, out int income))
                {
                    zavodTableAdapter.InsertZavod(NameTextBox.Text, TypeOfZavodBox.SelectedIndex + 1, income);
                    UpdateDataGrid();
                }
                else
                {
                    MessageBox.Show("Введите число в поле \"Прибыль завода\"!", "Ошибка");
                    return;
                }
            }
        }
        private void UpdateDataGrid()
        {
            mainWindow.MainDataGrid.ItemsSource = zavodTableAdapter.GetData();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
