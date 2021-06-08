namespace FootballScores.Services.OutputModels
{
    using System.Collections.Generic;

    public class LeagueOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<FixturesOutputModel> Fixtures { get; set; }
    }
}
