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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PsihologicalProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TYQuestion1 : Page
    {
        public TYQuestion1()
        {
            this.InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    TY.ArrayOfResults[NumberOfPage.Get(this.GetType()) - 1] = 0;
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TY.ArrayOfResults[NumberOfPage.Get(this.GetType()) - 1] = 0;
            this.Frame.Navigate(typeof(TYQuestion2));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TY.ArrayOfResults[NumberOfPage.Get(this.GetType()) - 1] = 1;
            this.Frame.Navigate(typeof(TYQuestion2));
        }

    }
}
