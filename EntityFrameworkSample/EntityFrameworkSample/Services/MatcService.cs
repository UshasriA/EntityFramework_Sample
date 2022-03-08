using EntityFrameworkSample.DBModels;
using EntityFrameworkSample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Services
{
    public class MatcService : IMatchService
    {
        IMatchRepository matchRepository;
        public MatcService(IMatchRepository _matchRepository)
        {
            matchRepository = _matchRepository;
        }
        public async Task<string> InsertTeam(string TeamName)
        {
            TournamentContext obj = new TournamentContext();
            Team team = new Team();
            team.TeamName = TeamName;

            obj.Teams.Add(team);
            obj.SaveChanges();
            return "Added successfully";
        }
    }
}
