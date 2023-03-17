using System.ComponentModel;
using System.Windows.Controls;
using FirstLab.DataSetTableAdapters;

namespace FirstLab
{
    /// <summary>
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        private zavodTableAdapter zavodTableAdapter = new zavodTableAdapter();
        public SecondPage()
        {
            InitializeComponent();
            SecondDataGrid.ItemsSource = zavodTableAdapter.GetData();
        }
        public zavodTableAdapter GetAdapter()
        {
            return zavodTableAdapter;
        }
        public DataGrid GetDataGrid()
        {
            return SecondDataGrid;
        }
    }
}
