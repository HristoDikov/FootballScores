namespace FootballScores.Models
{
    public class Statistic
    {
        public Statistic(int hostTeamShotsOnTarget, int hostTeamShotsOffTarget, int hostTeamPossession, int hostTeamCornerKicks, int hostTeamOffsides, int hostTeamFouls,
            int awayTeamShotsOnTarget, int awayTeamShotsOffTarget, int awayTeamPossession, int awayTeamCornerKicks, int awayTeamOffsides, int awayTeamFouls)
        {
            this.HostTeamShotsOnTarget = hostTeamShotsOnTarget;
            this.HostTeamShotsOffTarget = hostTeamShotsOffTarget;
            this.HostTeamPossession = hostTeamPossession;
            this.HostTeamCornerKicks = hostTeamCornerKicks;
            this.HostTeamOffsides = hostTeamOffsides;
            this.HostTeamFouls = hostTeamFouls;

            this.AwayTeamShotsOnTarget = awayTeamShotsOnTarget;
            this.AwayTeamShotsOffTarget = awayTeamShotsOffTarget;
            this.AwayTeamPossession = awayTeamPossession;
            this.AwayTeamCornerKicks = awayTeamCornerKicks;
            this.AwayTeamOffsides = awayTeamOffsides;
            this.AwayTeamFouls = awayTeamFouls;
        }

        public int HostTeamShotsOnTarget { get; private set; }

        public int HostTeamShotsOffTarget { get; private set; }

        public int HostTeamPossession { get; private set; }

        public int HostTeamCornerKicks { get; private set; }

        public int HostTeamOffsides { get; private set; }

        public int HostTeamFouls { get; private set; }

        public int AwayTeamShotsOnTarget { get; private set; }

        public int AwayTeamShotsOffTarget { get; private set; }

        public int AwayTeamPossession { get; private set; }

        public int AwayTeamCornerKicks { get; private set; }

        public int AwayTeamOffsides { get; private set; }

        public int AwayTeamFouls { get; private set; }
    }
}
