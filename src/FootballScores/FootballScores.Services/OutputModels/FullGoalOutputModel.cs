namespace FootballScores.Services.OutputModels
{
    public class FullGoalOutputModel : GoalOutputModel
    {
        public bool IsOwnGoal { get; set; }

        public bool IsPenalty { get; set; }
    }
}
