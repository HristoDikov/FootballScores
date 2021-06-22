namespace FootballScores.Services.Contracts
{
    using OutputModels;
    using System.Threading.Tasks;

    public interface IFixtureService
    {
        Task<FixtureWithStatsOutputModel> GetStatistic(int fixtureId); 
    }
}
