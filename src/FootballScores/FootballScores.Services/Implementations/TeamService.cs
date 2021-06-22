namespace FootballScores.Services.Implementations
{
    using Data;
    using Contracts;
    using System.Linq;
    using OutputModels;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public class TeamService : ITeamService
    {
        private readonly FootballStatsDbContext db;

        public TeamService(FootballStatsDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<PlayerOutputModel>> GetTeamPlayers(int teamId)
        => await this.db
             .Player
             .AsNoTracking()
             .Where(p => p.TeamId == teamId)
             .Select(t => new PlayerOutputModel
             {
                 Name = t.FirstName + " " + t.LastName,
                 Position = t.Position
             })
             .ToListAsync();
    }
}
