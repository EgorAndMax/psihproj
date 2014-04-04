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
using PsihologicalProject.Common;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace PsihologicalProject
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class ITResultPage : Page
    {
        private NavigationHelper navigationHelper;
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }
        public ITResultPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.RunScore.Text = "Набранное количество баллов: " + IT.Counter + "\n";
            if (IT.Counter <= 20)
            {
                this.RunResult.Text = "У тебя нет Интернет-зависимости.";
            }
            else if (IT.Counter < 50)
            {
                this.RunResult.Text = "Ты много времени проводишь в Интернете и ты в силах себя контролировать.";
            }
            else if (IT.Counter < 80)
            {
                this.RunResult.Text = "У тебя средняя Интернет-зависимость. Интернет оказывает влияние на твою жизнь и является причиной некоторых проблем.";
            }
            else
            {
                this.RunResult.Text = "У тебя сильная Интернет-зависимость. Интернет является причиной многих проблем в твоей жизни.";
            }
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GroupedItemsPage));
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ITDescriptionPage));
        }
    }
}
