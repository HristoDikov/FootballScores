namespace FootballScores.Services.Contracts
{
    using OutputModels;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface ILeagueService
    {
        Task<IEnumerable<LeagueOutputModel>> GetLeagues();

        Task<IEnumerable<FixturesOutputModel>> GetSpecificLeagueFixtures(int leagueId);

        Task<IEnumerable<FixturesOutputModel>> GetLeaguesFixturesByDate(int year, int month, int day);
    }
}
