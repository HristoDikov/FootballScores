namespace FootballScores.Data
{
    using FootballScores.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class GoalConfig : IEntityTypeConfiguration<Goal>
    {
        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder
                .HasKey(g => g.Id);

            builder
                .Property(g => g.MinuteScored)
                .IsRequired();

            builder
                .Property(g => g.IsOwnGoal)
                .IsRequired();

            builder
                .Property(g => g.IsPenalty)
                .IsRequired();
        }
    }
}
