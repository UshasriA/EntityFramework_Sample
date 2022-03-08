using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Repository
{
    public interface IMatchRepository
    {
        Task<string> InsertTeam(string TeamName);
    }
}
