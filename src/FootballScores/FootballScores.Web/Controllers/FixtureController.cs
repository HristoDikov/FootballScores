namespace FootballScores.Web.Controllers
{
    using Services.Contracts;
    using Services.OutputModels;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

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
            => Ok(await this.fixtureService.GetStatistic(fixtureId));
    }
}
