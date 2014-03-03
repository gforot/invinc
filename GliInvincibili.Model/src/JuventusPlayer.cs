using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace GliInvincibili.Model.src
{

    public enum JuventusPlayers
    {
        Buffon,
        Lichtsteiner,
        Barzagli,
        Chiellini,
        Bonucci,
        Caceres,
        Marchisio,
        Vidal,
        Pirlo,
        Giaccherini,
        Pepe,
        Matri,
        Delpiero,
        Vucinic,
        Quagliarella,
        Elia,
        Krasic,
        Borriello,
        Marrone,
        Deceglie,
        Storari,
        Estigarribia,
        Padoin, 
        Amauri,
        Iaquinta,
        Motta,
        Pazienza,
        Grosso,
        Manninger,
        Toni
    }

    public class JuventusPlayer : Player
    {
        private readonly JuventusPlayers _identifier;
        private readonly Ruolo _ruolo;
        private readonly int _numero;
        private readonly int _caps;
        private readonly string _image;
        private readonly int _reti;

        public JuventusPlayers Identifier { get { return _identifier; } }
        public Ruolo Ruolo { get { return _ruolo; } }
        public int Numero { get { return _numero; } }
        public int Caps { get { return _caps; } }
        public string Image { get { return _image; } }
        public int Reti { get { return _reti; } }


        public JuventusPlayer(string name, JuventusPlayers identifier, Ruolo ruolo, int numero, int caps, string image, int reti)
            : base(name)
        {
            _caps = caps;
            _identifier = identifier;
            _numero = numero;
            _ruolo = ruolo;
            _reti = reti;
            _image = image;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", _numero, Name, _ruolo);
        }
    }
}
