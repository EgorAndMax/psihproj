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

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace PsihologicalProject
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        private bool flag;
        public BlankPage1()
        {
            this.InitializeComponent();
            FramePsih.Navigate(typeof(Aizenk));
            flag = true;
        }

        private void FramePsih_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (flag)
            {
                FramePsih.Navigate(typeof(Aizenk));
                flag = false;
            }
            else
            {
                FramePsih.Navigate(typeof(Aizenk));
                flag = true;
            }
        }
    }
}
