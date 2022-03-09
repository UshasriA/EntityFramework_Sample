using EntityFrameworkSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Services
{
    public interface IMatchService
    {
        Task<string> InsertTeam(string TeamName);
        Task<string> InsertInspDetails(InspectionDetails inspectionDetails);

    }

}
