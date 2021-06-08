namespace FootballScores.Data
{
    using FootballScores.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            var navigationPlayers = builder.Metadata.FindNavigation(nameof(Team.Players));

            navigationPlayers.SetPropertyAccessMode(PropertyAccessMode.Field);

            var navigationHomeFixtures = builder.Metadata.FindNavigation(nameof(Team.HostFixtures));

            navigationHomeFixtures.SetPropertyAccessMode(PropertyAccessMode.Field);

            var navigationAwayFixtures = builder.Metadata.FindNavigation(nameof(Team.AwayFixtures));

            navigationAwayFixtures.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.
                HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .IsRequired();

            builder
                .Property(t => t.Country)
                .IsRequired();

            builder
                .Property(t => t.City)
                .IsRequired();

            builder
                .Property(t => t.GoalsScored)
                .IsRequired();

            builder
                .Property(t => t.GoalsConceded)
                .IsRequired();

            builder
                .Property(t => t.Manager)
                .IsRequired();

            builder
                .Property(t => t.Points)
                .IsRequired();

            builder
               .HasMany(t => t.Players)
               .WithOne(p => p.Team)
               .Metadata
               .PrincipalToDependent
               .SetField("players");
        }
    }
}
