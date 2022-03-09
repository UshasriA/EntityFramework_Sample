using EntityFrameworkSample.Models;
using EntityFrameworkSample.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Controllers
{
    
    [Route("Match")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        IMatchService matchService;
        public MatchController(IMatchService _matchService)
        {
            matchService = _matchService;

            var s = DateTime.Now;

            InspectionDetails inspection = new InspectionDetails();

            var ss = JsonConvert.SerializeObject(inspection);
        }

        [HttpPost("InsertTeam")]
       public IActionResult InsertTeam (string teamName)
        {
           matchService.InsertTeam(teamName);
            return Ok("Success");
        }
        [HttpPost("InsertInspDetails")]
        public IActionResult InsertInspDetails(InspectionDetails inspectionDetails)
        {
            matchService.InsertInspDetails(inspectionDetails);
            return Ok("Succeeded");
        }
    }
}
