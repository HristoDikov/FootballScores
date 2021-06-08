namespace FootballScores.Services.Contracts
{
    using FootballScores.Services.OutputModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITeamService 
    {
        Task<IEnumerable<PlayerOutputModel>> GetTeamPlayers(int teamId);
    }
}
