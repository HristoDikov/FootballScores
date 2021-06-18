namespace FootballScores.Services.OutputModels
{
    using System.Collections.Generic;

    public class LeagueOutputModel
    {
        public int LeagueId { get; set; }

        public string LeagueName { get; set; }

        public IEnumerable<FixturesOutputModel> Fixtures { get; set; }
    }
}
