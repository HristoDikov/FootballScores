namespace FootballScores.Services.Implementations
{
    using FootballScores.Data;
    using FootballScores.Services.Contracts;
    using FootballScores.Services.OutputModels;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class FixtureService : IFixtureService
    {
        private readonly FootballStatsDbContext db;

        public FixtureService(FootballStatsDbContext db)
        {
            this.db = db;
        }

        public async Task<FixtureWithStatsOutputModel> GetStatistic(int fixtureId)
        {
            return await this.db
                .Fixtures
                .Where(f => f.Id == fixtureId)
                .Select(f => new FixtureWithStatsOutputModel
                {
                    AwayTeamCornerKicks = f.Statistic.AwayTeamCornerKicks,
                    AwayTeamFouls = f.Statistic.AwayTeamFouls,
                    AwayTeamOffsides = f.Statistic.AwayTeamOffsides,
                    AwayTeamPossession = f.Statistic.AwayTeamPossession,
                    AwayTeamShotsOffTarget = f.Statistic.AwayTeamShotsOffTarget,
                    AwayTeamShotsOnTarget = f.Statistic.AwayTeamShotsOnTarget,
                    HostTeamCornerKicks = f.Statistic.HostTeamCornerKicks,
                    HostTeamFouls = f.Statistic.HostTeamFouls,
                    HostTeamOffsides = f.Statistic.HostTeamOffsides,
                    HostTeamPossession = f.Statistic.HostTeamPossession,
                    HostTeamShotsOnTarget = f.Statistic.HostTeamShotsOnTarget,
                    HostTeamShotsOffTarget = f.Statistic.HostTeamShotsOffTarget,
                    Goals = f.Score.Select(s => new FullGoalOutputModel 
                    {
                        MinuteScored = s.MinuteScored,
                        IsOwnGoal = s.IsOwnGoal,
                        IsPenalty = s.IsPenalty,
                        Scorer = s.Scorer.FirstName + " " + s.Scorer.LastName
                    })
                })
                .FirstOrDefaultAsync();
        }
    }
}
