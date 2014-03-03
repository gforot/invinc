
using System;
using System.Collections.Generic;

namespace GliInvincibili.Model.src
{
    public class League
    {
        public const int NumberOfTeamsOfTheLeague = 20;
        public static int NumberOfMatchesPerGirone = (NumberOfTeamsOfTheLeague - 1);
        public static int NumberOfMatches = NumberOfMatchesPerGirone*2;

        private readonly List<Match> _matches;
        private Teams _leagueTeams;

        public List<Match> Matches
        {
            get { return _matches; }
        }

        public League()
        {
            _matches = new List<Match>();
        }

        public void SetLeagueTeams(Teams teams)
        {
            _leagueTeams = teams;
        }

        public Team GetTeam(LeagueTeams team)
        {
            return _leagueTeams == null ? null : _leagueTeams.GetTeam(team);
        }

        public void AddMatch(Match match)
        {
            if(CheckMatch(match))
            {
                _matches.Add(match);
            }
            else
            {
                throw new Exception("Match già aggiunto");
            }
        }

        private bool CheckMatch(Match match)
        {
            //To do: Implemenatare
            if (_matches.Contains(match)) 
                return false;
            if (match.MatchDay > NumberOfMatchesPerGirone) 
                return false;
            if((match.AwayTeamScore<0)||(match.HomeTeamScore<0))
            {
                throw new Exception(string.Format("{0} non corretto! I gol sono negativi", match.ToString()));
            }

            if ((match.AwayTeamScore != match.AwayTeamScorers.Count) || (match.HomeTeamScore < 0))
            {
                throw new Exception(string.Format("{0} non corretto! Non corrispondono i marcatori con il risultato", match.ToString()));
            }
            return true;
        }

        public bool CheckLeague()
        {
            if (_matches.Count < NumberOfMatches)
            {
                throw new Exception(string.Format("Mancano delle partite!({0} compilate su {1})",_matches.Count, NumberOfMatches));
            }
            return true;
        }

        public static League CreateJuventusLeague2012()
        {
            League league = new League();
            //Team juveTeam = Team.GetJuveTeam();
            //Teams leagueTeams = Teams.GetLeagueTeams();
            league.SetLeagueTeams(Teams.GetLeagueTeams());
            Team juveTeam = league.GetTeam(LeagueTeams.Juventus);
            #region Match 1 (udinese)
            Match match1a = new Match(1, league.GetTeam(LeagueTeams.Udinese), juveTeam, 0, 0, Girone.Andata);
            Match match1r = new Match(1, juveTeam, league.GetTeam(LeagueTeams.Udinese), 2, 1, Girone.Ritorno);
            match1r.AddHomeScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Matri), juveTeam.GetJuventusPlayer(JuventusPlayers.Matri) });
            match1r.AddAwayScorer(new Player("Floro Flores"));
            #endregion
            #region Match 2 (parma)
            Match match2a = new Match(2, juveTeam, league.GetTeam(LeagueTeams.Parma), 4, 1, Girone.Andata);
            match2a.AddHomeScorers(new []{juveTeam.GetJuventusPlayer(JuventusPlayers.Lichtsteiner), juveTeam.GetJuventusPlayer(JuventusPlayers.Pepe), juveTeam.GetJuventusPlayer(JuventusPlayers.Vidal)
                , juveTeam.GetJuventusPlayer(JuventusPlayers.Marchisio)});
            match2a.AddAwayScorer(new Player("Giovinco"));
            Match match2r = new Match(2, league.GetTeam(LeagueTeams.Parma), juveTeam, 0, 0, Girone.Ritorno);
            #endregion
            #region Match 3 (siena)
            Match match3a = new Match(3, league.GetTeam(LeagueTeams.Siena), juveTeam, 0, 1, Girone.Andata);
            match3a.AddAwayScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Matri));
            Match match3r = new Match(3, juveTeam, league.GetTeam(LeagueTeams.Siena), 0, 0, Girone.Ritorno);
            #endregion
            #region Match 4 (Bologna)
            Match match4a = new Match(4, juveTeam, league.GetTeam(LeagueTeams.Bologna), 1, 1, Girone.Andata);
            match4a.AddHomeScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Vucinic));
            match4a.AddAwayScorer(new Player("Portanova"));
            Match match4r = new Match(4, league.GetTeam(LeagueTeams.Bologna), juveTeam, 1, 1, Girone.Ritorno);
            match4r.AddHomeScorer(new Player("Di Vaio"));
            match4r.AddAwayScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Vucinic));
            #endregion
            #region Match 5 (Catania)
            Match match5a = new Match(5, league.GetTeam(LeagueTeams.Catania), juveTeam, 1, 1, Girone.Andata);
            match5a.AddHomeScorer(new Player("Bergessio"));
            match5a.AddAwayScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Krasic));
            Match match5r = new Match(5, juveTeam, league.GetTeam(LeagueTeams.Catania), 3, 1, Girone.Ritorno);
            match5r.AddAwayScorer(new Player("Barrientos"));
            match5r.AddHomeScorers(new []
                                       {
                                           juveTeam.GetJuventusPlayer(JuventusPlayers.Pirlo),
                                           juveTeam.GetJuventusPlayer(JuventusPlayers.Chiellini),
                                           juveTeam.GetJuventusPlayer(JuventusPlayers.Quagliarella)
                                       });
            #endregion
            #region Match 6 (milan)
            Match match6a = new Match(6, juveTeam, league.GetTeam(LeagueTeams.Milan), 2, 0, Girone.Andata);
            match6a.AddHomeScorers(new []{juveTeam.GetJuventusPlayer(JuventusPlayers.Marchisio), juveTeam.GetJuventusPlayer(JuventusPlayers.Marchisio)});
            Match match6r = new Match(6, league.GetTeam(LeagueTeams.Milan), juveTeam, 1, 1, Girone.Ritorno);
            match6r.AddAwayScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Matri));
            match6r.AddHomeScorer(new Player("Nocerino"));
            #endregion
            #region Match 7 (chievo)
            Match match7a = new Match(7, league.GetTeam(LeagueTeams.Chievo), juveTeam, 0, 0, Girone.Andata);
            Match match7r = new Match(7, juveTeam, league.GetTeam(LeagueTeams.Chievo), 1, 1, Girone.Ritorno);
            match7r.AddAwayScorer(new Player("Dramè"));
            match7r.AddHomeScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Deceglie));
            #endregion
            #region Match 8 (genoa)
            Match match8a = new Match(8, juveTeam, league.GetTeam(LeagueTeams.Genoa), 2, 2, Girone.Andata);
            match8a.AddHomeScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Matri), juveTeam.GetJuventusPlayer(JuventusPlayers.Matri) });
            match8a.AddAwayScorers(new []{new Player("Rossi"),new Player("Caracciolo"),  });
            Match match8r = new Match(8, league.GetTeam(LeagueTeams.Genoa), juveTeam, 0, 0, Girone.Ritorno);
            #endregion
            #region Match 9 (fiorentina)
            Match match9a = new Match(9, juveTeam, league.GetTeam(LeagueTeams.Fiorentina), 2, 1, Girone.Andata);
            match9a.AddHomeScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Bonucci), juveTeam.GetJuventusPlayer(JuventusPlayers.Matri) });
            match9a.AddAwayScorer(new Player("Jovetic"));
            Match match9r = new Match(9, league.GetTeam(LeagueTeams.Fiorentina), juveTeam, 0, 5, Girone.Ritorno);
            match9r.AddAwayScorers(new[] { 
                juveTeam.GetJuventusPlayer(JuventusPlayers.Vucinic), 
                juveTeam.GetJuventusPlayer(JuventusPlayers.Vidal),
                juveTeam.GetJuventusPlayer(JuventusPlayers.Marchisio), 
                juveTeam.GetJuventusPlayer(JuventusPlayers.Pirlo),
                juveTeam.GetJuventusPlayer(JuventusPlayers.Padoin), 
            });
            #endregion
            #region Match 10 (inter)
            Match match10a = new Match(10, league.GetTeam(LeagueTeams.Inter), juveTeam, 1, 2, Girone.Andata);
            match10a.AddHomeScorer(new Player("Maicon"));
            match10a.AddAwayScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Vucinic), juveTeam.GetJuventusPlayer(JuventusPlayers.Marchisio) });
            Match match10r = new Match(10, juveTeam, league.GetTeam(LeagueTeams.Inter), 2, 0, Girone.Ritorno);
            match10a.AddHomeScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Caceres), juveTeam.GetJuventusPlayer(JuventusPlayers.Delpiero) });
            #endregion
            #region Match 11 (napoli)
            Match match11a = new Match(11, league.GetTeam(LeagueTeams.Napoli), juveTeam, 3, 3, Girone.Andata);
            match11a.AddHomeScorers(new[] { new Player("Hamsik"), new Player("Pandev"), new Player("Pandev"), });
            match11a.AddAwayScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Matri), juveTeam.GetJuventusPlayer(JuventusPlayers.Estigarribia), juveTeam.GetJuventusPlayer(JuventusPlayers.Pepe) });
            Match match11r = new Match(11, juveTeam, league.GetTeam(LeagueTeams.Napoli), 3, 0, Girone.Ritorno);
            match11a.AddHomeScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Bonucci), juveTeam.GetJuventusPlayer(JuventusPlayers.Vidal), juveTeam.GetJuventusPlayer(JuventusPlayers.Quagliarella) });
            #endregion
            #region Match 12 (palermo)
            Match match12a = new Match(12, juveTeam, league.GetTeam(LeagueTeams.Palermo), 3, 0, Girone.Andata);
            match12a.AddHomeScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Pepe), juveTeam.GetJuventusPlayer(JuventusPlayers.Matri), juveTeam.GetJuventusPlayer(JuventusPlayers.Marchisio) });
            Match match12r = new Match(12, league.GetTeam(LeagueTeams.Palermo), juveTeam, 0, 2, Girone.Ritorno);
            match12r.AddAwayScorers(new []{juveTeam.GetJuventusPlayer(JuventusPlayers.Bonucci), juveTeam.GetJuventusPlayer(JuventusPlayers.Quagliarella)});
            #endregion
            #region Match 13 (lazio)
            Match match13a = new Match(13, league.GetTeam(LeagueTeams.Lazio), juveTeam, 0, 1, Girone.Andata);
            match13a.AddAwayScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Pepe));
            Match match13r = new Match(13, juveTeam, league.GetTeam(LeagueTeams.Lazio), 2, 1, Girone.Ritorno);
            match13r.AddHomeScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Pepe), juveTeam.GetJuventusPlayer(JuventusPlayers.Delpiero) });
            match13r.AddAwayScorer(new Player("Mauri"));
            #endregion
            #region Match 14 (cesena)
            Match match14a = new Match(14, juveTeam, league.GetTeam(LeagueTeams.Cesena), 2, 0, Girone.Andata);
            match12a.AddHomeScorers(new[] {juveTeam.GetJuventusPlayer(JuventusPlayers.Marchisio), juveTeam.GetJuventusPlayer(JuventusPlayers.Vidal) });
            Match match14r = new Match(14, league.GetTeam(LeagueTeams.Cesena), juveTeam, 0, 1, Girone.Ritorno);
            match14r.AddAwayScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Borriello));
            #endregion
            #region Match 15 (roma)
            Match match15a = new Match(15, league.GetTeam(LeagueTeams.Roma), juveTeam, 1, 1, Girone.Andata);
            match15a.AddHomeScorer(new Player("De Rossi"));
            match15a.AddAwayScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Chiellini));
            Match match15r = new Match(15, juveTeam, league.GetTeam(LeagueTeams.Roma), 4, 0, Girone.Ritorno);
            match15r.AddHomeScorers(
                new []
                    {
                        juveTeam.GetJuventusPlayer(JuventusPlayers.Vidal),
                        juveTeam.GetJuventusPlayer(JuventusPlayers.Vidal),
                        juveTeam.GetJuventusPlayer(JuventusPlayers.Pirlo),
                        juveTeam.GetJuventusPlayer(JuventusPlayers.Marchisio)
        });

            #endregion
            #region Match 16 (novara)
            Match match16a = new Match(16, juveTeam, league.GetTeam(LeagueTeams.Novara), 2, 0, Girone.Andata);
            match16a.AddHomeScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Pepe), juveTeam.GetJuventusPlayer(JuventusPlayers.Quagliarella) });
            Match match16r = new Match(16, league.GetTeam(LeagueTeams.Novara), juveTeam, 0, 4, Girone.Ritorno);
            match16r.AddAwayScorers(new[]
                                        {
                                            juveTeam.GetJuventusPlayer(JuventusPlayers.Vucinic),
                                            juveTeam.GetJuventusPlayer(JuventusPlayers.Borriello),
                                            juveTeam.GetJuventusPlayer(JuventusPlayers.Vidal),
                                            juveTeam.GetJuventusPlayer(JuventusPlayers.Vucinic),
        });
            #endregion
            #region Match 17 (lecce)
            Match match17a = new Match(17, league.GetTeam(LeagueTeams.Lecce), juveTeam, 0, 1, Girone.Andata);
            match17a.AddAwayScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Matri));
            Match match17r = new Match(17, juveTeam, league.GetTeam(LeagueTeams.Lecce), 1, 1, Girone.Ritorno);
            match17r.AddAwayScorer(new Player("Bertolacci"));
            match17r.AddHomeScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Marchisio));
            #endregion
            #region Match 18 (cagliari)
            Match match18a = new Match(18, juveTeam, league.GetTeam(LeagueTeams.Cagliari), 1, 1, Girone.Andata);
            match18a.AddHomeScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Vucinic));
            match18a.AddAwayScorer(new Player("Cossu"));
            Match match18r = new Match(18, league.GetTeam(LeagueTeams.Cagliari), juveTeam, 0, 2, Girone.Ritorno);
            match18r.AddAwayScorers(new []{juveTeam.GetJuventusPlayer(JuventusPlayers.Vucinic), new Player("Canini"), });
            #endregion
            #region Match 19 (atalanta)
            Match match19a = new Match(19, league.GetTeam(LeagueTeams.Atalanta), juveTeam, 0, 2, Girone.Andata);
            match19a.AddAwayScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Lichtsteiner), juveTeam.GetJuventusPlayer(JuventusPlayers.Giaccherini) });
            Match match19r = new Match(19, juveTeam, league.GetTeam(LeagueTeams.Atalanta), 3, 1, Girone.Ritorno);
            match19r.AddHomeScorers(new[] { juveTeam.GetJuventusPlayer(JuventusPlayers.Marrone), juveTeam.GetJuventusPlayer(JuventusPlayers.Delpiero), juveTeam.GetJuventusPlayer(JuventusPlayers.Barzagli) });
            match19r.AddAwayScorer(juveTeam.GetJuventusPlayer(JuventusPlayers.Lichtsteiner));
            #endregion
            league.AddMatch(match1a);
            league.AddMatch(match1r);
            league.AddMatch(match2a);
            league.AddMatch(match2r);
            league.AddMatch(match3a);
            league.AddMatch(match3r);
            league.AddMatch(match4a);
            league.AddMatch(match4r);
            league.AddMatch(match5a);
            league.AddMatch(match5r);
            league.AddMatch(match6a);
            league.AddMatch(match6r);
            league.AddMatch(match7a);
            league.AddMatch(match7r);
            league.AddMatch(match8a);
            league.AddMatch(match8r);
            league.AddMatch(match9a);
            league.AddMatch(match9r);
            league.AddMatch(match10a);
            league.AddMatch(match10r);
            league.AddMatch(match11a);
            league.AddMatch(match11r);
            league.AddMatch(match12a);
            league.AddMatch(match12r);
            league.AddMatch(match13a);
            league.AddMatch(match13r);
            league.AddMatch(match14a);
            league.AddMatch(match14r);
            league.AddMatch(match15a);
            league.AddMatch(match15r);
            league.AddMatch(match16a);
            league.AddMatch(match16r);
            league.AddMatch(match17a);
            league.AddMatch(match17r);
            league.AddMatch(match18a);
            league.AddMatch(match18r);
            league.AddMatch(match19a);
            league.AddMatch(match19r);
            league.CheckLeague();
            return league;
        }

    }
}
