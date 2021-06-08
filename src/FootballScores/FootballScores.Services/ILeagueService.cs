namespace FootballScores.Services
{
    using FootballScores.Services.OutputModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILeagueService
    {
        Task<IEnumerable<LeagueOutputModel>> GetLeagues();

        Task<IEnumerable<FixturesOutputModel>> GetSpecificLeagueFixtures(int leagueId);

        Task<IEnumerable<FixturesOutputModel>> GetLeaguesFixturesByDate(int year, int month, int day);
    }
}
