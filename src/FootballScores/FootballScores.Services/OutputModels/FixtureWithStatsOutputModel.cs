namespace FootballScores.Services.OutputModels
{
    using System.Collections.Generic;

    public class FixtureWithStatsOutputModel
    {
        public int HostTeamShotsOnTarget { get; set; }

        public int HostTeamShotsOffTarget { get; set; }

        public int HostTeamPossession { get; set; }

        public int HostTeamCornerKicks { get; set; }

        public int HostTeamOffsides { get; set; }

        public int HostTeamFouls { get; set; }

        public int AwayTeamShotsOnTarget { get; set; }

        public int AwayTeamShotsOffTarget { get; set; }

        public int AwayTeamPossession { get; set; }

        public int AwayTeamCornerKicks { get; set; }

        public int AwayTeamOffsides { get; set; }

        public int AwayTeamFouls { get; set; }

        public IEnumerable<GoalOutputModel> Goals { get; set; }
    }
}