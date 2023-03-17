
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace FirstLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        readonly public static Page[] pages =
        {
            new FirstPage(), new SecondPage()
        };
        private int x = 0;
        public MainWindow()
        {
            InitializeComponent();
            PageFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            ReturnButton.IsEnabled= false;
            PageFrame.Content = pages[0];
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            x++;
            PageFrame.Content = pages[x];
            ReturnButton.IsEnabled = true;
            if (x <= pages.Length - 1)
            {
                NextButton.IsEnabled = false;
            }

        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            x--;
            NextButton.IsEnabled = true;
            PageFrame.Content = pages[x];
            if (x < 1)
            {
                ReturnButton.IsEnabled = false;
            }
        }
       

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (PageFrame.Content == pages[1])
            {
                new CreateZavodWindow().Show();
            }   
            else if (PageFrame.Content == pages[0]) 
            {
                new CreateSpecWindow().Show(); 
            }
        }
    }
}
