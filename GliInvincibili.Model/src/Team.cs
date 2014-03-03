
using System.Collections.Generic;

namespace GliInvincibili.Model.src
{
    public class Team
    {
        private readonly LeagueTeams _teamId;
        private Rosa _rosa;
        public LeagueTeams TeamId { get { return _teamId; } }

        public Rosa Rosa { get { return _rosa; } }

        public Team(LeagueTeams team)
        {
            _teamId = team;
        }

        public void SetRosa(Rosa rosa)
        {
            _rosa = rosa;
        }

        public JuventusPlayer GetJuventusPlayer(JuventusPlayers name)
        {
            return _rosa.GetJuvePlayer(name);
        }

        public static Team GetJuveTeam()
        {
            Team juve = new Team(LeagueTeams.Juventus);
            juve.SetRosa(Rosa.CreateRosaJuve());
            return juve;
        }

        public override string ToString()
        {
            return _teamId.ToString();
        }
        
    }
}
