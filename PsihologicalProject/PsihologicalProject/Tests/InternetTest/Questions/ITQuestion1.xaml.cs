using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace PsihologicalProject.InternetTest
{
    public sealed partial class ITQuestion1 : Page
    {
        public ITQuestion1()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IT.Counter += 1;
            this.Frame.Navigate(typeof(ITQuestion2));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IT.Counter += 2;
            this.Frame.Navigate(typeof(ITQuestion2));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            IT.Counter += 3;
            this.Frame.Navigate(typeof(ITQuestion2));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            IT.Counter += 4;
            this.Frame.Navigate(typeof(ITQuestion2));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            IT.Counter += 5;
            this.Frame.Navigate(typeof(ITQuestion2));
        }
    }
}
