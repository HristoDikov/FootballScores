namespace FootballScores.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Fixture 
    {
        private readonly HashSet<Goal> score;

        public Fixture(DateTime gameDate, string venue, string referee)
        {
            this.GameDate = gameDate;
            this.Venue = venue;
            this.Referee = referee;

            this.score = new HashSet<Goal>();
        }

        public int Id { get; set; }

        public Team HostTeam { get; set; }

        public int HostTeamId { get; set; }

        public Team AwayTeam { get; set; }

        public int AwayTeamId { get; set; }

        public ICollection<Goal> Score => this.score.ToList().AsReadOnly();

        public Statistic Statistic { get; private set; }

        public int LeagueId { get; set; }

        public League League { get; set; }

        public DateTime GameDate { get; private set; }

        public string Venue { get; set; }

        public string Referee { get; set; }
    }
}
