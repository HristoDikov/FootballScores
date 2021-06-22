namespace FootballScores.Web.Controllers
{
    using Services.Contracts;
    using Services.OutputModels;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

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
            => Ok(await this.teamService.GetTeamPlayers(teamId));
    }
}
