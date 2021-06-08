namespace FootballScores.Web.Controllers
{
    using FootballScores.Services.Contracts;
    using FootballScores.Services.OutputModels;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class TeamController : ApiController
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        [HttpGet]
        [Route(nameof(GetTeamPlayers))]
        public async Task<ActionResult<IEnumerable<PlayerOutputModel>>> GetTeamPlayers(int teamId)
        {
            return Ok(await this.teamService.GetTeamPlayers(teamId));
        }
    }
}
