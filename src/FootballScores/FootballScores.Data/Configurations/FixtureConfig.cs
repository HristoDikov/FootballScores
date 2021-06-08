namespace FootballScores.Data
{
    using FootballScores.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class FixtureConfig : IEntityTypeConfiguration<Fixture>
    {
        public void Configure(EntityTypeBuilder<Fixture> builder)
        {
            builder
                .HasKey(f => f.Id);

            builder
                .Property(f => f.Venue)
                .IsRequired();

            builder
                .Property(f => f.Referee)
                .IsRequired();

            builder
                .Property(f => f.GameDate)
                .IsRequired();

            builder
                .OwnsOne(f => f.Statistic, s =>
                {
                    s.WithOwner();

                    s.Property(st => st.HostTeamCornerKicks);
                    s.Property(st => st.HostTeamFouls);
                    s.Property(st => st.HostTeamOffsides);
                    s.Property(st => st.HostTeamPossession);
                    s.Property(st => st.HostTeamShotsOnTarget);
                    s.Property(st => st.AwayTeamCornerKicks);
                    s.Property(st => st.AwayTeamFouls);
                    s.Property(st => st.AwayTeamOffsides);
                    s.Property(st => st.AwayTeamPossession);
                    s.Property(st => st.AwayTeamCornerKicks);
                    s.Property(st => st.AwayTeamShotsOffTarget);
                });

            builder
                .HasMany(f => f.Score)
                .WithOne(g => g.Fixture)
                .Metadata
                .PrincipalToDependent
                .SetField("score");

            builder
                .HasOne(f => f.HostTeam)
                .WithMany(t => t.HostFixtures)
                .HasForeignKey(f => f.HostTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);

                      builder
                .HasOne(f => f.AwayTeam)
                .WithMany(t => t.AwayFixtures)
                .HasForeignKey(f => f.AwayTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);;
        }
    }
}
