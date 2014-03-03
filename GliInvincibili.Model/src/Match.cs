
using System.Collections.Generic;

namespace GliInvincibili.Model.src
{
    public enum Girone
    {
        Andata,
        Ritorno
    }

    public class Match
    {
        public int MatchDay { get; private set; }
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }
        public int HomeTeamScore { get; private set; }
        public int AwayTeamScore { get; private set; }
        public Girone Girone { get; private set; }

        private readonly List<Player> _homeTeamScorers;
        public List<Player> HomeTeamScorers { get { return _homeTeamScorers; } }
        private readonly List<Player> _awayTeamScorers;
        public List<Player> AwayTeamScorers { get { return _awayTeamScorers; } }

        public string Description { get { return ToString(); } }


        public Match(int matchDay, Team homeTeam, Team awayTeam, int homeTeamScore, int awayTeamScore, Girone girone)
        {
            MatchDay = matchDay;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeTeamScore = homeTeamScore;
            AwayTeamScore = awayTeamScore;
            Girone = girone;
            _awayTeamScorers = new List<Player>();
            _homeTeamScorers = new List<Player>();
        }

        public void AddHomeScorer(Player scorer)
        {
            _homeTeamScorers.Add(scorer);
        }

        public void AddHomeScorers(IEnumerable<Player> scorers)
        {
            _homeTeamScorers.AddRange(scorers);
        }

        public void AddAwayScorer(Player scorer)
        {
            _awayTeamScorers.Add(scorer);
        }

        public void AddAwayScorers(IEnumerable<Player> scorers)
        {
            _awayTeamScorers.AddRange(scorers);
        }

        public override bool Equals(object obj)
        {
            try
            {
                return (obj is Match) && 
                    (obj as Match).MatchDay == MatchDay &&
                    (obj as Match).Girone == Girone;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}-{3}", HomeTeam, AwayTeam, HomeTeamScore, AwayTeamScore);
        }
    }
}
