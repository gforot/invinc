
using System.Collections.Generic;
using System.Linq;

namespace GliInvincibili.Model.src
{
    public enum Ruolo
    {
        Portiere,
        Difensore,
        Centrocampista,
        Attaccante
    }

    public class Rosa : List<JuventusPlayer>
    {
        public static Rosa CreateRosaJuve()
        {
            Rosa rosa = new Rosa();

            rosa.Add(new JuventusPlayer("Gianluigi Buffon",JuventusPlayers.Buffon, Ruolo.Portiere, 1, 35, "/image/Buffon.jpg", -16));
            rosa.Add(new JuventusPlayer("Marco Storari", JuventusPlayers.Storari, Ruolo.Portiere, 30, 3, "/image/Storari.jpg", -4));
            rosa.Add(new JuventusPlayer("Alex Manninger", JuventusPlayers.Manninger, Ruolo.Portiere, 13, 0, "/image/Manninger.jpg", 0));

            rosa.Add(new JuventusPlayer("Andrea Barzagli", JuventusPlayers.Barzagli, Ruolo.Difensore, 15, 35, "/image/Barzagli.jpg", 1));
            rosa.Add(new JuventusPlayer("Leonardo Bonucci", JuventusPlayers.Bonucci, Ruolo.Difensore, 19, 32, "/image/Bonucci.jpg", 2));
            rosa.Add(new JuventusPlayer("Giorgio Chiellini", JuventusPlayers.Chiellini, Ruolo.Difensore, 3, 34, "/image/Chiellini.jpg", 2));
            rosa.Add(new JuventusPlayer("Martin Caceres", JuventusPlayers.Caceres, Ruolo.Difensore, 4, 11, "/image/Caceres.jpg", 1));
            rosa.Add(new JuventusPlayer("Paolo De Ceglie", JuventusPlayers.Deceglie, Ruolo.Difensore, 11, 21, "/image/Deceglie.jpg", 1));
            rosa.Add(new JuventusPlayer("Stephan Lichtsteiner", JuventusPlayers.Lichtsteiner, Ruolo.Difensore, 26, 35, "/image/Lichtsteiner.jpg", 2));
            //rosa.Add(new JuventusPlayer("Marco Motta", JuventusPlayers.Motta, Ruolo.Difensore, 2, -1, "/image/Motta.jpg"));
            rosa.Add(new JuventusPlayer("Fabio Grosso", JuventusPlayers.Grosso, Ruolo.Difensore, 6, 2, "/image/Grosso.jpg", 0));

            rosa.Add(new JuventusPlayer("Simone Pepe", JuventusPlayers.Pepe, Ruolo.Centrocampista, 7, 31, "/image/Pepe.jpg", 6));
            rosa.Add(new JuventusPlayer("Arturo Vidal", JuventusPlayers.Vidal, Ruolo.Centrocampista, 22, 33, "/image/Vidal.jpg", 7));
            rosa.Add(new JuventusPlayer("Andrea Pirlo", JuventusPlayers.Pirlo, Ruolo.Centrocampista, 21, 37, "/image/Pirlo.jpg", 3));
            rosa.Add(new JuventusPlayer("Simone Padoin", JuventusPlayers.Padoin, Ruolo.Centrocampista, 20, 6, "/image/Padoin.jpg", 1));
            rosa.Add(new JuventusPlayer("Emanuele Giaccherini", JuventusPlayers.Giaccherini, Ruolo.Centrocampista, 24, 23, "/image/Giaccherini.jpg", 1));
            rosa.Add(new JuventusPlayer("Luca Marrone", JuventusPlayers.Marrone, Ruolo.Centrocampista, 34, 3, "/image/Marrone.jpg", 1));
            rosa.Add(new JuventusPlayer("Milos Krasic", JuventusPlayers.Krasic, Ruolo.Centrocampista, 27, 7, "/image/Krasic.jpg", 1));
            rosa.Add(new JuventusPlayer("Eljero Elia", JuventusPlayers.Elia, Ruolo.Centrocampista, 17, 4, "/image/Elia.jpg", 0));
            rosa.Add(new JuventusPlayer("Marcelo Estigarribia", JuventusPlayers.Estigarribia, Ruolo.Centrocampista, 28, 14, "/image/Estigarribia.jpg", 1));
            //rosa.Add(new JuventusPlayer("Michele Pazienza", JuventusPlayers.Pazienza, Ruolo.Centrocampista, 5, -1, "/image/Pazienza.jpg"));
            rosa.Add(new JuventusPlayer("Claudio Marchisio", JuventusPlayers.Marchisio, Ruolo.Centrocampista, 8, 36, "/image/Marchisio.jpg", 9));

            rosa.Add(new JuventusPlayer("Mirko Vucinic", JuventusPlayers.Vucinic, Ruolo.Attaccante, 14, 32, "/image/Vucinic.jpg", 9));
            rosa.Add(new JuventusPlayer("Alessandro Delpiero", JuventusPlayers.Delpiero, Ruolo.Attaccante, 10, 23, "/image/Delpiero.jpg", 3));
            rosa.Add(new JuventusPlayer("Alessandro Matri", JuventusPlayers.Matri, Ruolo.Attaccante, 32, 31, "/image/Matri.jpg", 10));
            rosa.Add(new JuventusPlayer("Fabio Quagliarella", JuventusPlayers.Quagliarella, Ruolo.Attaccante, 18, 23, "/image/Quagliarella.jpg", 4));
            rosa.Add(new JuventusPlayer("Marco Borriello", JuventusPlayers.Borriello, Ruolo.Attaccante, 23, 13, "/image/Borriello.jpg", 2));
            //rosa.Add(new JuventusPlayer("Vincenzo Iaquinta", JuventusPlayers.Iaquinta, Ruolo.Attaccante, 9, -1, "/image/Iaquinta.jpg"));
            //rosa.Add(new JuventusPlayer("Amauri", JuventusPlayers.Amauri, Ruolo.Attaccante, 38, -1, "/image/Amauri.jpg"));
            //rosa.Add(new JuventusPlayer("Luca Toni", JuventusPlayers.Toni, Ruolo.Attaccante, 20, -1, "/image/Toni.jpg"));
            return rosa;
        }

        public JuventusPlayer GetJuvePlayer(JuventusPlayers identifier)
        {
            return this.Where(pl => pl.Identifier == identifier).FirstOrDefault();
        }
    }
}
