using System;
using GliInvincibili.src.viewModel;
using Microsoft.Phone.Controls;

namespace GliInvincibili.gui
{
    public partial class MatchDetail : PhoneApplicationPage
    {
        private readonly MatchDetailViewModel _vm;
        public MatchDetail()
        {
            InitializeComponent();
            SetText();
            _vm = new MatchDetailViewModel(MainPage.SelectedMatch);
            this.DataContext = _vm;
        }

        private void SetText()
        {
            this.ApplicationTitle.Text = AppResources.AppTitle;
        }

        //private void ApplicationBarIconButton_Click(object sender, System.EventArgs e)
        //{
        //    MainPage.SelectedMatch = null;
        //    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        //}

    }
}