namespace FootballScores.Data
{
    using FootballScores.Data.Extensions;
    using FootballScores.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;

    public class FootballStatsDbContext : DbContext
    {
        public FootballStatsDbContext(DbContextOptions<FootballStatsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fixture> Fixtures { get; set; }

        public DbSet<League> Leagues { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<Goal> Goals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Seed();

            base.OnModelCreating(builder);
        }
    }
}
