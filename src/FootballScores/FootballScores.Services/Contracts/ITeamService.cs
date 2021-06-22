namespace FootballScores.Services.Contracts
{
    using OutputModels;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface ITeamService 
    {
        Task<IEnumerable<PlayerOutputModel>> GetTeamPlayers(int teamId);
    }
}
