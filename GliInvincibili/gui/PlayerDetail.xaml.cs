using System;
using System.Windows;
using GliInvincibili.src.viewModel;
using Microsoft.Phone.Controls;

namespace GliInvincibili.gui
{
    public partial class PlayerDetail : PhoneApplicationPage
    {
        private readonly PlayerDetailViewModel _vm;
        public PlayerDetail()
        {
            InitializeComponent();
            _vm = new PlayerDetailViewModel(MainPage.SelectedPlayer);
            this.DataContext = _vm;
            SetText();
        }

        private void SetText()
        {
            this.role.Text = AppResources.Role;
            this.name.Text = AppResources.Name;
            this.number.Text = AppResources.Number;
            this.caps.Text = AppResources.Caps;
            this.ApplicationTitle.Text = AppResources.AppTitle;
            this.reti.Text = AppResources.Reti;
        }

        //private void ApplicationBarIconButton_Click(object sender, System.EventArgs e)
        //{
        //    MainPage.SelectedPlayer = null;
        //    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        //}
    }
}