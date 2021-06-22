namespace FootballScores.Services.Implementations
{
    using Data;
    using Contracts;
    using System.Linq;
    using OutputModels;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public class FixtureService : IFixtureService
    {
        private readonly FootballStatsDbContext db;

        public FixtureService(FootballStatsDbContext db)
        {
            this.db = db;
        }

        public async Task<FixtureWithStatsOutputModel> GetStatistic(int fixtureId)
        => await this.db
                .Fixtures
                .AsNoTracking()
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
