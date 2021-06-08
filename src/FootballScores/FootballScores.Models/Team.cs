namespace FootballScores.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private readonly HashSet<Fixture> awayFixtures;
        private readonly HashSet<Fixture> hostFixtures;
        private readonly HashSet<Player> players;

        public Team(string name, string country, string city, int goalsScored, int goalsConceded, string manager)
        {
            this.Name = name;
            this.Country = country;
            this.City = city;
            this.GoalsScored = goalsScored;
            this.GoalsConceded = goalsConceded;
            this.Manager = manager;

            this.hostFixtures = new HashSet<Fixture>();
            this.awayFixtures = new HashSet<Fixture>();
            this.players = new HashSet<Player>();
        }

        public int Id { get; set; }

        public string Name { get; private set; }

        public string Country { get; private set; }

        public string City { get; private set; }

        public int GoalsScored { get; private set; }

        public int GoalsConceded { get; private set; }

        public string Manager { get; set; }

        public int GoalDiff
        {
            get { return this.GoalsScored - this.GoalsConceded; }
        }

        public int Points { get; private set; }

        public int LeagueId { get; set; }

        public League League { get; set; }

        public ICollection<Player> Players
            => this.players.ToList().AsReadOnly();

        public ICollection<Fixture> HostFixtures
        => this.hostFixtures.ToList().AsReadOnly();

        public ICollection<Fixture> AwayFixtures
            => this.awayFixtures.ToList().AsReadOnly();


        public void AddPlayer(Player player)
            => this.players.Add(player);

        public void AddHomeFixture(Fixture fixture)
            => this.hostFixtures.Add(fixture);

        public void AddAwayFixture(Fixture fixture)
           => this.awayFixtures.Add(fixture);
    }
}
