namespace FootballScores.Services.Contracts
{
    using FootballScores.Services.OutputModels;
    using System.Threading.Tasks;

    public interface IFixtureService
    {
        Task<FixtureWithStatsOutputModel> GetStatistic(int fixtureId); 
    }
}
