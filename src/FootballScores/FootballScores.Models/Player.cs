namespace FootballScores.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        private int assists;
        private readonly ICollection<Goal> goals;

        public Player(string firstName, string lastName, string position, int assists)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
            this.assists = assists;
            this.goals = new HashSet<Goal>();
        }

        public int Id { get; set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Position { get; private set; }

        public int Assists { get => assists; }

        public ICollection<Goal> Goals => this.goals.ToList().AsReadOnly();

        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}
