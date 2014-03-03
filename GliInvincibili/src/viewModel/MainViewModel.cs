
using System.Collections.Generic;
using GliInvincibili.Model.src;

namespace GliInvincibili.src.viewModel
{
    public class MainViewModel
    {
        private readonly League _league;

        public MainViewModel(League league)
        {
            _league = league;
        }

        public Team JuventusTeam { get { return _league.GetTeam(LeagueTeams.Juventus); } }

        public Rosa Rosa
        {
            get { return JuventusTeam.Rosa; }
        }

        public List<Match> Matches
        {
            get { return _league.Matches; }
        }
    }
}
