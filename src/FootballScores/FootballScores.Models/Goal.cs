namespace FootballScores.Models
{
    public class Goal
    {
        public Goal(int minuteScored, bool isOwnGoal, bool isPenalty)
        {
            this.MinuteScored = minuteScored;
            this.IsOwnGoal = isOwnGoal;
            this.IsPenalty = isPenalty;
        }

        public int Id { get; set; }

        public int MinuteScored { get; }

        public bool IsOwnGoal { get; private set; }

        public bool IsPenalty { get; private set; }

        public int ScorerId { get; set; }

        public Player Scorer { get; private set; }

        public int FixtureId { get; set; }

        public Fixture Fixture { get; set; }
    }
}
