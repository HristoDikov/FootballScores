namespace FootballScores.Services.OutputModels
{
    using System.Collections.Generic;

    public class TeamOutputModel
    {
        public IEnumerable<PlayerOutputModel> Players { get; set; }
    }
}
