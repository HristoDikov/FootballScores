namespace FootballScores.Web.Controllers
{
    using FootballScores.Services.Contracts;
    using FootballScores.Services.OutputModels;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class FixtureController : ApiController
    {
        private readonly IFixtureService fixtureService;

        public FixtureController(IFixtureService fixtureService)
        {
            this.fixtureService = fixtureService;
        }

        [HttpGet]
        [Route(nameof(Get))]
        public async Task<ActionResult<IEnumerable<FixturesOutputModel>>> Get(int fixtureId)
        {
            return Ok(await this.fixtureService.GetStatistic(fixtureId));
        }
    }
}
