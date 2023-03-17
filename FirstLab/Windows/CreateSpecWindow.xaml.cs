using SecondLab.DataSetTableAdapters;
using System.Windows;


namespace SecondLab
{
    /// <summary>
    /// Логика взаимодействия для CreateSpecWindow.xaml
    /// </summary>
    public partial class CreateSpecWindow : Window
    {
        private specializationsTableAdapter specializationsTableAdapter = new specializationsTableAdapter();
        public MainWindow mainWindow;
        public CreateSpecWindow()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            SetDataGrid();
        }
        private void SetDataGrid()
        {
            if (NameTextBox.Text != string.Empty)
            {
                specializationsTableAdapter.InsertSpecName(NameTextBox.Text);
                UpdateDataGrid();
                MessageBox.Show("Запись добавлена!", "Успех");
            }
            else
            {
                MessageBox.Show("Введите название специализации!", "Ошибка");
            }
        }
        private void UpdateDataGrid()
        {
            mainWindow.MainDataGrid.ItemsSource = specializationsTableAdapter.GetData();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
