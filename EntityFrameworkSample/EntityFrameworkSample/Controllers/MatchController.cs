using EntityFrameworkSample.Services;
using Microsoft.AspNetCore.Mvc;
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
        }

        [HttpPost("InsertTeam")]
       public IActionResult InsertTeam (string teamName)
        {
           matchService.InsertTeam(teamName);
            return Ok("Success");
        }
    }
}
