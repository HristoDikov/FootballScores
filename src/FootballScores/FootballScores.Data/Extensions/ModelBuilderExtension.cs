namespace FootballScores.Data.Extensions
{
    using FootballScores.Models;
    using Microsoft.EntityFrameworkCore;
    using System;

    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>().HasData(
              new League("La Liga", DateTime.Now, DateTime.Now.AddDays(200)) { Id = 1, },
              new League("Premier League", DateTime.Now, DateTime.Now.AddDays(200)) { Id = 2 },
            new League("Ligue 1", DateTime.Now, DateTime.Now.AddDays(200)) { Id = 3 });

            modelBuilder.Entity<Team>().HasData(
              new Team("Real Madrid", "Spain", "Madrid", 3, 0, "Carlo") { Id = 1, LeagueId = 1 },
              new Team("Barcelona", "Spain", "Barcelona", 2, 2, "Ronald Koeman") { Id = 2, LeagueId = 1 });
            //new Team("Atltico Madrid", "Spain", "Madrid", 2, 1, "Diego Simeone") { Id = 3, LeagueId = 1 },
            //new Team("Villareal", "Spain", "Villareal", 1, 2, "Unai Emery") { Id = 4, LeagueId = 1 });


            modelBuilder.Entity<Team>().HasData(
              new Team("Manchester United", "England", "Macnchester", 3, 0, "Ole Gunar") { Id = 3, LeagueId = 2 },
              new Team("Manchester City", "England", "Manchester", 2, 2, "Pep Guardiola") { Id = 4, LeagueId = 2 });
            //new Team("Chelsea", "England", "London", 2, 1, "Thomas Tuchel") { Id = 7, LeagueId = 2 },
            //new Team("Liverpool", "England", "Liverpool", 1, 2, "Jurgen Klopp") { Id = 8, LeagueId = 2 });


            modelBuilder.Entity<Team>().HasData(
              new Team("PSG", "France", "Paris", 3, 0, "Pochettino") { Id = 5, LeagueId = 3 },
              new Team("Lyon", "France", "Lyon", 2, 2, "Rudy Garcia") { Id = 6, LeagueId = 3 });
            //new Team("Lille", "France", "Lille", 2, 1, "Christoph Galtie") { Id = 11, LeagueId = 3 },
            //new Team("Monaco", "France", "Monaco", 1, 2, "Leonardo Jardim") { Id = 12, LeagueId = 3 });

            modelBuilder.Entity<Player>().HasData(
              new Player("Marcelo", "Aveiro", "LB", 1) { Id = 1, TeamId = 1 },
              new Player("Karim", "Benzema", "CF", 1) { Id = 2, TeamId = 1 });

            modelBuilder.Entity<Player>().HasData(
              new Player("Lionel", "Messi", "CF", 1) { Id = 3, TeamId = 2 },
              new Player("Sergio", "Burgos", "MF", 0) { Id = 4, TeamId = 2 });

            modelBuilder.Entity<Player>().HasData(
             new Player("Paul","Pogba", "MF", 1) { Id = 5, TeamId = 3 },
             new Player("Bruno","Fernandes", "MF", 1) { Id = 6, TeamId = 3 });

            modelBuilder.Entity<Player>().HasData(
                new Player("Phil", "Phoden", "MF", 1) { Id = 7, TeamId = 4 },
                new Player("Raheem",  "Sterling", "MF", 0) { Id = 8, TeamId = 4 });

            modelBuilder.Entity<Player>().HasData(
            new Player("Angel", "DiMaria", "MF", 1) { Id = 9, TeamId = 5 },
            new Player("Kylian", "Mbappe", "MF", 1) { Id = 10, TeamId = 5 });

            modelBuilder.Entity<Player>().HasData(
             new Player("Lukas",  "Paqueta", "MF", 1) { Id = 11, TeamId = 6 },
             new Player("Bruno", "Gimaraesh", "MF", 1) { Id = 12, TeamId = 6 });

            modelBuilder.Entity<Fixture>(f =>
            {
                f.HasData(new
                {
                    GameDate = DateTime.Now,
                    Venue = "Bernabeu",
                    Referee = "Soza",
                    Id = 1,
                    HostTeamId = 1,
                    CreatedOn = DateTime.Now,
                    AwayTeamId = 2,
                    LeagueId = 1,
                });
                f.OwnsOne(s => s.Statistic).HasData(new
                {
                    HostTeamShotsOnTarget = 1,
                    HostTeamShotsOffTarget = 2,
                    HostTeamPossession = 60,
                    HostTeamCornerKicks = 2,
                    HostTeamOffsides = 3,
                    HostTeamFouls = 4,
                    AwayTeamShotsOnTarget = 5,
                    AwayTeamShotsOffTarget = 6,
                    AwayTeamPossession = 40,
                    AwayTeamCornerKicks = 5,
                    AwayTeamOffsides = 10,
                    AwayTeamFouls = 11,
                    FixtureId = 1,
                    CreatedOn = DateTime.Now
                });
            });
            modelBuilder.Entity<Fixture>(f =>
            {
                f.HasData(new
                {
                    GameDate = DateTime.Now,
                    Venue = "Old Traford",
                    Referee = "Mark Clattenberg",
                    Id = 2,
                    HostTeamId = 3,
                    CreatedOn = DateTime.Now,
                    LeagueId = 2,
                    AwayTeamId = 4
                });
                f.OwnsOne(s => s.Statistic).HasData(new
                {
                    HostTeamShotsOnTarget = 1,
                    HostTeamShotsOffTarget = 2,
                    HostTeamPossession = 60,
                    HostTeamCornerKicks = 2,
                    HostTeamOffsides = 3,
                    HostTeamFouls = 4,
                    AwayTeamShotsOnTarget = 5,
                    AwayTeamShotsOffTarget = 6,
                    AwayTeamPossession = 40,
                    AwayTeamCornerKicks = 5,
                    AwayTeamOffsides = 10,
                    AwayTeamFouls = 11,
                    FixtureId = 2,
                    CreatedOn = DateTime.Now
                });
            });
            modelBuilder.Entity<Fixture>(f =>
            {
                f.HasData(new
                {
                    GameDate = DateTime.Now,
                    Venue = "PSG Arena",
                    Referee = "Jan Pam",
                    Id = 3,
                    HostTeamId = 5,
                    CreatedOn = DateTime.Now,
                    AwayTeamId = 6,
                    LeagueId = 3
                });
                f.OwnsOne(s => s.Statistic).HasData(new
                {
                    HostTeamShotsOnTarget = 1,
                    HostTeamShotsOffTarget = 2,
                    HostTeamPossession = 60,
                    HostTeamCornerKicks = 2,
                    HostTeamOffsides = 3,
                    HostTeamFouls = 4,
                    AwayTeamShotsOnTarget = 5,
                    AwayTeamShotsOffTarget = 6,
                    AwayTeamPossession = 40,
                    AwayTeamCornerKicks = 5,
                    AwayTeamOffsides = 10,
                    AwayTeamFouls = 11,
                    FixtureId = 3,
                    CreatedOn = DateTime.Now
                });
            });
            //.HasData(
            //   // new Fixture().,
            //new Fixture(DateTime.Now, "Old Traford", "Mark Ham", new Statistic(10, 10, 50, 1, 2, 2, 10, 11, 50, 2, 3, 4)) { Id = 2, HostTeamId = 3, AwayTeamId = 4 },
            //new Fixture(DateTime.Now, "PSG ARena", "Jan Pan", new Statistic(10, 10, 50, 1, 2, 2, 10, 11, 50, 2, 3, 4)) { Id = 3, HostTeamId = 5, AwayTeamId = 6 });

            modelBuilder.Entity<Goal>().HasData(
                    new Goal(10, false, false) { Id = 1, ScorerId = 1, FixtureId = 1 },
                    new Goal(50, false, false) { Id = 2, ScorerId = 2, FixtureId = 1 },
                    new Goal(50, false, false) { Id = 3, ScorerId = 3, FixtureId = 2 },
                    new Goal(50, false, false) { Id = 4, ScorerId = 4, FixtureId = 2 });
        }
    }
}
