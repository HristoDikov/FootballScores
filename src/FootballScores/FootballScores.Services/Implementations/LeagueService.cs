namespace FootballScores.Services.Implementations
{
    using System;
    using AutoMapper;
    using System.Linq;
    using FootballScores.Data;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper.QueryableExtensions;
    using FootballScores.Services.Contracts;
    using FootballScores.Services.OutputModels;

    public class LeagueService : ILeagueService
    {
        private readonly FootballStatsDbContext db;
        private readonly IMapper mapper;


        public LeagueService(FootballStatsDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<LeagueOutputModel>> GetLeagues()
        => await this.db
             .Leagues
             .AsNoTracking()
             .ProjectTo<LeagueOutputModel>(this.mapper.ConfigurationProvider)
             .ToListAsync();

        public async Task<IEnumerable<FixturesOutputModel>> GetSpecificLeagueFixtures(int leagueId)
        => await this.db
             .Fixtures
             .AsNoTracking()
             .Where(f => f.LeagueId == leagueId)
             .ProjectTo<FixturesOutputModel>(this.mapper.ConfigurationProvider)
             .ToListAsync();

        public async Task<IEnumerable<FixturesOutputModel>> GetLeaguesFixturesByDate(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day).Date;

            return await this.db
                .Fixtures
                .AsNoTracking()
                .Where(f => f.GameDate.Date == date)
                .ProjectTo<FixturesOutputModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
