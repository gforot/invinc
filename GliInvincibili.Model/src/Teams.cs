using System;
using System.Collections.Generic;
using System.Linq;

namespace GliInvincibili.Model.src
{
    public enum LeagueTeams
    {
        Juventus,
        Udinese,
        Parma,
        Siena,
        Bologna,
        Catania,
        Milan,
        Chievo,
        Genoa,
        Fiorentina,
        Inter,
        Napoli,
        Palermo,
        Lazio,
        Cesena,
        Roma,
        Novara,
        Lecce,
        Cagliari,
        Atalanta
    }

    public class Teams : List<Team>
    {
        public static Teams GetLeagueTeams()
        {
            Teams teams = new Teams();
            teams.AddRange(new []
                               {
                                   Team.GetJuveTeam(),
                                   new Team(LeagueTeams.Atalanta),
                                   new Team(LeagueTeams.Parma),
                                   new Team(LeagueTeams.Bologna),
                                   new Team(LeagueTeams.Cagliari),
                                   new Team(LeagueTeams.Catania),
                                   new Team(LeagueTeams.Cesena),
                                   new Team(LeagueTeams.Chievo),
                                   new Team(LeagueTeams.Siena),
                                   new Team(LeagueTeams.Lazio),
                                   new Team(LeagueTeams.Lecce),
                                   new Team(LeagueTeams.Palermo),
                                   new Team(LeagueTeams.Milan),
                                   new Team(LeagueTeams.Inter),
                                   new Team(LeagueTeams.Genoa),
                                   new Team(LeagueTeams.Udinese),
                                   new Team(LeagueTeams.Fiorentina),
                                   new Team(LeagueTeams.Roma),
                                   new Team(LeagueTeams.Novara),
                                   new Team(LeagueTeams.Napoli),
                               });
            teams.CheckTeams();
            
            return teams;
        }

        public void CheckTeams()
        {
            if (this.Count != League.NumberOfTeamsOfTheLeague)
            {
                throw new Exception("Numero di squadre sbagliato!!");
            }
        }

        public Team GetTeam(LeagueTeams team)
        {
            return this.Where(t => t.TeamId == team).FirstOrDefault();
        }
    }
}
