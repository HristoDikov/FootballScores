namespace FootballScores.Services.Implementations
{
    using FootballScores.Data;
    using FootballScores.Models;
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
              .AsNoTracking()
             .Select(l => new LeagueOutputModel
             {
                 LeagueId = l.Id,
                 LeagueName = l.Name,
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
                     Score = f.Score.Where(s => s.Scorer.TeamId == f.HostTeamId).Count().ToString() + " : " + f.Score.Where(s => s.Scorer.TeamId == f.AwayTeamId).Count().ToString()
                 })
             })
                .ToListAsync();

        public async Task<IEnumerable<FixturesOutputModel>> GetSpecificLeagueFixtures(int leagueId)
        => await this.db
             .Fixtures
             .AsNoTracking()
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
                 Score = f.Score.Where(s => s.Scorer.TeamId == f.HostTeamId).Count().ToString() + " : " + f.Score.Where(s => s.Scorer.TeamId == f.AwayTeamId).Count().ToString()

             })
             .ToListAsync();

        public async Task<IEnumerable<FixturesOutputModel>> GetLeaguesFixturesByDate(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day).Date;

            return await this.db
                .Fixtures
                .AsNoTracking()
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
                    Score = f.Score.Where(s => s.Scorer.TeamId == f.HostTeamId).Count().ToString() + " : " + f.Score.Where(s => s.Scorer.TeamId == f.AwayTeamId).Count().ToString()

                })
                .ToListAsync();
        }
    }
}
