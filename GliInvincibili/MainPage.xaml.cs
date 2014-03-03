using System;
using System.Windows;
using System.Windows.Controls;
using GliInvincibili.Model.src;
using GliInvincibili.src.viewModel;
using Microsoft.Phone.Controls;

namespace GliInvincibili
{
    public partial class MainPage : PhoneApplicationPage
    {
        private static int _selectedPivot = -1;
        public static JuventusPlayer SelectedPlayer { get; set; }
        public static Match SelectedMatch { get; set; }

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            DataContext = new MainViewModel(League.CreateJuventusLeague2012());

            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
            SelectedPlayer = null;
            SelectedMatch = null;

            SetText();
        }

        private void SetText()
        {
            this.rosaPivot.Header = AppResources.Rosa;
            this.campionatoPivot.Header = AppResources.Campionato;
            this.pivot.Title = AppResources.AppTitle;
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void lbRosa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbRosa.SelectedIndex < 0) return;

            object selectedItem = lbRosa.SelectedItem;
            if (selectedItem is JuventusPlayer)
            {
                JuventusPlayer player = selectedItem as JuventusPlayer;
                SelectedPlayer = player;
                NavigationService.Navigate(new Uri("/gui/PlayerDetail.xaml?selectedPlayer=" + player, UriKind.Relative));
            }

            lbRosa.SelectedIndex = -1;
        }

        private void lbCampionato_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbCampionato.SelectedIndex < 0) return;

            object selectedItem = lbCampionato.SelectedItem;
            if(selectedItem is Match)
            {
                Match match = selectedItem as Match;
                SelectedMatch = match;
                NavigationService.Navigate(new Uri("/gui/MatchDetail.xaml", UriKind.Relative));
            }

            lbCampionato.SelectedIndex = -1;
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            _selectedPivot = pivot.SelectedIndex;
            base.OnNavigatedFrom(e);
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (_selectedPivot>0)
            {
                pivot.SelectedIndex = _selectedPivot;
                _selectedPivot = -1;
            }
            base.OnNavigatedTo(e);
        }
    }
}