namespace FootballScores.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using FootballScores.Services.Contracts;
    using FootballScores.Services.OutputModels;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class LeagueController : ApiController
    {
        private readonly ILeagueService leagueService;

        public LeagueController(ILeagueService leagueService)
        {
            this.leagueService = leagueService;
        }

        [HttpGet]
        [Route(nameof(List))]
        public async Task<ActionResult<IEnumerable<LeagueOutputModel>>> List()
            => Ok(await this.leagueService.GetLeagues());

        [HttpGet]
        [Route(nameof(GetFixturesForLeague))]
        public async Task<ActionResult<IEnumerable<LeagueOutputModel>>> GetFixturesForLeague(int leagueId)
            => Ok(await this.leagueService.GetSpecificLeagueFixtures(leagueId));

        [HttpGet]
        [Route(nameof(GetFixturesForLeagueByDate))]
        public async Task<ActionResult<IEnumerable<LeagueOutputModel>>> GetFixturesForLeagueByDate(int year, int month, int day)
            => Ok(await this.leagueService.GetLeaguesFixturesByDate(year, month, day));
    }
}
