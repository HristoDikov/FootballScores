namespace FootballScores.Data
{
    using FootballScores.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            var navigation = builder.Metadata.FindNavigation(nameof(Player.Goals));

            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.FirstName)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .IsRequired();

            builder
                .Property(p => p.Position)
                .IsRequired();

            builder
                .Property(p => p.Assists)
                .IsRequired();

            builder
             .HasMany(l => l.Goals)
             .WithOne(g => g.Scorer)
             .HasForeignKey(g => g.ScorerId)
             .Metadata
             .PrincipalToDependent
             .SetField("goals");
        }
    }
}
