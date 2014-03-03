using GliInvincibili.Model.src;

namespace GliInvincibili.src.viewModel
{
    public class PlayerDetailViewModel
    {
        private readonly JuventusPlayer _juventusPlayer;

        public PlayerDetailViewModel(JuventusPlayer player)
        {
            _juventusPlayer = player;
        }

        public string Name { get { return _juventusPlayer.Name; } }
        public string Image { get { return _juventusPlayer.Image; } }
        public int Number { get { return _juventusPlayer.Numero; } }
        public int Caps { get { return _juventusPlayer.Caps; } }
        public string Ruolo { get { return _juventusPlayer.Ruolo.ToString(); } }
        public int Reti { get { return _juventusPlayer.Reti; } }
    }
}
