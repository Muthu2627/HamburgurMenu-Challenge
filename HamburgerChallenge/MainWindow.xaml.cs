using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace HamburgerChallenge
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            AppFrame.Navigate(typeof(BlankPage1));
            AppName.Text = "Finance";
            
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MenuList.IsPaneOpen = !MenuList.IsPaneOpen;
        }

        private void SearchBarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FinanceBox.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                
                AppFrame?.Navigate(typeof(BlankPage1));
                AppName.Text = "Finance";
            }
            else if (FoodBox.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                AppFrame.Navigate(typeof(BlankPage2));
                AppName.Text = "Food";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(typeof(BlankPage1));
            BackButton.Visibility = Visibility.Collapsed;
            AppName.Text = "Finance";
            FinanceBox.IsSelected = true;
            
        }
    }
}
