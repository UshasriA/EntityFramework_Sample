using EntityFrameworkSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Repository
{
    public class MatchRepository : IMatchRepository
    {
        
        public Task<string> InsertInspDetails(InspectionDetails inspectionDetails)
        {
            throw new NotImplementedException();
        }

        public Task<string> InsertTeam(string TeamName)
        {
            throw new NotImplementedException();
        }
    }
}
