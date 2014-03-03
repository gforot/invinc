
using System.Collections.Generic;
using GliInvincibili.Model.src;

namespace GliInvincibili.src.viewModel
{
    public class MatchDetailViewModel
    {
        private readonly Match _match;
        public MatchDetailViewModel(Match match)
        {
            _match = match;
        }

        public string Description { get { return _match.Description; } }
        public string HomeTeam { get { return _match.HomeTeam.ToString(); } }
        public string AwayTeam { get { return _match.AwayTeam.ToString(); } }
        public int HomeTeamScore { get { return _match.HomeTeamScore; } }
        public int AwayTeamScore { get { return _match.AwayTeamScore; } }
        public List<Player> HomeTeamScorers { get { return _match.HomeTeamScorers; } }
        public List<Player> AwayTeamScorers { get { return _match.AwayTeamScorers; } }
    }
}
