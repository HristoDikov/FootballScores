namespace FootballScores.Services.Implementations
{
    using FootballScores.Data;
    using FootballScores.Services.Contracts;
    using FootballScores.Services.OutputModels;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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
