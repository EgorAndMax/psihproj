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
    public sealed partial class TGResultPage : Page
    {
        public TGResultPage()
        {
            this.InitializeComponent();
            TG.GetTopList();
            if (TG.TopList.Count == 0)
            {
                this.RunResult.Text = "Мы не смогли определить на основании ваших ответов ваш тип интелекта.";
            }
            else
            {
                this.RunResult.Text = "Вы обладаете " + TG.GetContent() + "типом интелекта.";
                this.Run1.Text = TG.GetDescription();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GroupedItemsPage));
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TGDecriptionPage));
        }
    }
}
