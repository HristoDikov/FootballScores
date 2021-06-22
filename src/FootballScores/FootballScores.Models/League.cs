namespace FootballScores.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class League
    {
        private readonly HashSet<Fixture> fixtures;
        private readonly HashSet<Team> teams;

        public League(string name, DateTime startDate, DateTime endDate)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;

            this.fixtures = new HashSet<Fixture>();
            this.teams = new HashSet<Team>();
        }
        public int Id { get; set; }

        public string Name { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public ICollection<Fixture> Fixtures
            => this.fixtures.ToList().AsReadOnly();

        public ICollection<Team> Teams
            => this.teams.ToList().AsReadOnly();
    }
}
