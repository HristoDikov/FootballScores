namespace FootballScores.Services.OutputModels
{

    public class FixturesOutputModel
    {
        public int Id { get; set; }

        public int HostTeamId { get; set; }

        public int AwayTeamId { get; set; }

        public string HostTeamName { get; set; }

        public string AwayTeamName { get; set; }

        public string Score { get; set; }

        public string GameDate { get; set; }

        public string Venue { get; set; }

        public string Referee { get; set; }
    }
}
