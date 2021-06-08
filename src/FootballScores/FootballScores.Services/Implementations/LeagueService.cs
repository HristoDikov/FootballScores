namespace FootballScores.Services.Implementations
{
    using FootballScores.Data;
    using FootballScores.Services.Contracts;
    using FootballScores.Services.OutputModels;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class LeagueService : ILeagueService
    {
        private readonly FootballStatsDbContext db;

        public LeagueService(FootballStatsDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<LeagueOutputModel>> GetLeagues()
       => await this.db
            .Leagues
                .Select(l => new LeagueOutputModel
                {
                    Id = l.Id,
                    Name = l.Name,
                    Fixtures = l.Fixtures.Select(f => new FixturesOutputModel
                    {
                        Id = f.Id,
                        HostTeamId = f.HostTeamId,
                        AwayTeamId = f.AwayTeamId,
                        HostTeamName = f.HostTeam.Name,
                        AwayTeamName = f.AwayTeam.Name,
                        GameDate = f.GameDate.ToString(),
                        Referee = f.Referee,
                        Venue = f.Venue,
                        Score = f.Score.Select(s => new GoalOutputModel
                        {
                            MinuteScored = s.MinuteScored,
                            Scorer = s.Scorer.FirstName + " " + s.Scorer.LastName
                        })
                    })
                })
                .ToListAsync();

        public async Task<IEnumerable<FixturesOutputModel>> GetSpecificLeagueFixtures(int leagueId)
        => await this.db
                .Fixtures
                .Where(f => f.LeagueId == leagueId)
                .Select(f => new FixturesOutputModel
                {

                    Id = f.Id,
                    HostTeamId = f.HostTeamId,
                    AwayTeamId = f.AwayTeamId,
                    HostTeamName = f.HostTeam.Name,
                    AwayTeamName = f.AwayTeam.Name,
                    GameDate = f.GameDate.ToString(),
                    Referee = f.Referee,
                    Venue = f.Venue,
                    Score = f.Score.Select(s => new GoalOutputModel
                    {
                        MinuteScored = s.MinuteScored,
                        Scorer = s.Scorer.FirstName + " " + s.Scorer.LastName
                    })
                })
                .ToListAsync();

        public async Task<IEnumerable<FixturesOutputModel>> GetLeaguesFixturesByDate(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day).Date;
            return await this.db
                .Fixtures
                .Where(f => f.GameDate.Date == date)
                .Select(f => new FixturesOutputModel
                {

                    Id = f.Id,
                    HostTeamId = f.HostTeamId,
                    AwayTeamId = f.AwayTeamId,
                    HostTeamName = f.HostTeam.Name,
                    AwayTeamName = f.AwayTeam.Name,
                    GameDate = f.GameDate.ToString(),
                    Referee = f.Referee,
                    Venue = f.Venue,
                    Score = f.Score.Select(s => new GoalOutputModel
                    {
                        MinuteScored = s.MinuteScored,
                        Scorer = s.Scorer.FirstName + " " + s.Scorer.LastName
                    })
                })
                .ToListAsync();


        }

    }
}
