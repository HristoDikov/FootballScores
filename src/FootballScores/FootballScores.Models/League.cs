namespace FootballScores.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class League
    {
        private readonly HashSet<Fixture> fixtures;
        private readonly HashSet<Team> teams;

        public League(string name, string season, int playedRounds, DateTime startDate, DateTime endDate)
        {
            this.Name = name;
            this.Season = season;
            this.PlayedRounds = playedRounds;
            this.StartDate = startDate;
            this.EndDate = endDate;

            this.fixtures = new HashSet<Fixture>();
            this.teams = new HashSet<Team>();
        }
        public int Id { get; set; }

        public string Name { get; private set; }

        public string Season { get; private set; }

        public int PlayedRounds { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public ICollection<Fixture> Fixtures
            => this.fixtures.ToList().AsReadOnly();

        public ICollection<Team> Teams
            => this.teams.ToList().AsReadOnly();

        public void AddGame(Fixture fixture)
            => this.fixtures.Add(fixture);

        public void AddTeam(Team team)
            => this.teams.Add(team);
    }
}
