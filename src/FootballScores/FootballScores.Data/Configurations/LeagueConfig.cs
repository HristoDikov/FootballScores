namespace FootballScores.Data
{
    using FootballScores.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class LeagueConfig : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {

            var navigationFixtures = builder.Metadata.FindNavigation(nameof(League.Fixtures));

            navigationFixtures.SetPropertyAccessMode(PropertyAccessMode.Field);

            var navigationTeams = builder.Metadata.FindNavigation(nameof(League.Teams));

            navigationTeams.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder
                .HasKey(l => l.Id);

            builder
                .Property(l => l.Name)
                .IsRequired();

            builder
                .Property(l => l.StartDate)
                .IsRequired();

            builder
                .Property(l => l.EndDate)
                .IsRequired();

            builder
             .HasMany(l => l.Fixtures)
             .WithOne(f => f.League)
             .Metadata
             .PrincipalToDependent
             .SetField("fixtures");

            builder
            .HasMany(l => l.Teams)
            .WithOne(t => t.League)
            .OnDelete(DeleteBehavior.Restrict)
            .Metadata
            .PrincipalToDependent
            .SetField("teams");
        }
    }
}
