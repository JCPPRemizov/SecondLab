using FirstLab.DataSetTableAdapters;
using System.ComponentModel;
using System.Windows.Controls;

namespace FirstLab
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        private specializationsTableAdapter specializationsTableAdapter = new specializationsTableAdapter();
        public FirstPage()
        {
            InitializeComponent();
            FirstDataGrid.ItemsSource = specializationsTableAdapter.GetData();
        }
        public specializationsTableAdapter GetAdapter()
        {
            return specializationsTableAdapter;
        }
        public DataGrid GetDataGrid()
        {
            return FirstDataGrid;
        }
    }
}
