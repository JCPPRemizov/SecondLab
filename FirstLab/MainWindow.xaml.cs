
using SecondLab.DataSetTableAdapters;
using SecondLab.Windows;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;

namespace SecondLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private int x = 0;
        private CreateSpecWindow specWindow = new CreateSpecWindow();
        private CreateZavodWindow zavodWindow = new CreateZavodWindow();
        DataTable[] tables =
        {
            new specializationsTableAdapter().GetData(),
            new zavodTableAdapter().GetData()
        };

        public MainWindow()
        {
            InitializeComponent();
            MainDataGrid.ItemsSource = tables[0] as IEnumerable;
            specWindow.mainWindow = this;
            zavodWindow.mainWindow = this;

        }
        private void backStep()
        {
            if (x > 0)
            {
                x--;
                MainDataGrid.ItemsSource = tables[x] as IEnumerable;
            }
        }
        private void nextStep()
        {
            if (x < tables.Length - 1)
            {
                x++;
                MainDataGrid.ItemsSource = tables[x] as IEnumerable;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            nextStep();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            backStep();
        }
       

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainDataGrid.ItemsSource == tables[0])
                specWindow.Show();
            else if (MainDataGrid.ItemsSource == tables[1])
                zavodWindow.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
