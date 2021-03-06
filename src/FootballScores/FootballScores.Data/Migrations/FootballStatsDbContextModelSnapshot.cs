// <auto-generated />
using System;
using FootballScores.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FootballScores.Data.Migrations
{
    [DbContext(typeof(FootballStatsDbContext))]
    partial class FootballStatsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FootballScores.Models.Fixture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HostTeamId")
                        .HasColumnType("int");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Referee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HostTeamId");

                    b.HasIndex("LeagueId");

                    b.ToTable("Fixtures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AwayTeamId = 2,
                            GameDate = new DateTime(2021, 6, 8, 12, 56, 7, 848, DateTimeKind.Local).AddTicks(6452),
                            HostTeamId = 1,
                            LeagueId = 1,
                            Referee = "Soza",
                            Venue = "Bernabeu"
                        },
                        new
                        {
                            Id = 2,
                            AwayTeamId = 4,
                            GameDate = new DateTime(2021, 6, 8, 12, 56, 7, 850, DateTimeKind.Local).AddTicks(1700),
                            HostTeamId = 3,
                            LeagueId = 2,
                            Referee = "Mark Clattenberg",
                            Venue = "Old Traford"
                        },
                        new
                        {
                            Id = 3,
                            AwayTeamId = 6,
                            GameDate = new DateTime(2021, 6, 8, 12, 56, 7, 850, DateTimeKind.Local).AddTicks(5900),
                            HostTeamId = 5,
                            LeagueId = 3,
                            Referee = "Jan Pam",
                            Venue = "PSG Arena"
                        });
                });

            modelBuilder.Entity("FootballScores.Models.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FixtureId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOwnGoal")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPenalty")
                        .HasColumnType("bit");

                    b.Property<int>("MinuteScored")
                        .HasColumnType("int");

                    b.Property<int>("ScorerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FixtureId");

                    b.HasIndex("ScorerId");

                    b.ToTable("Goals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FixtureId = 1,
                            IsOwnGoal = false,
                            IsPenalty = false,
                            MinuteScored = 10,
                            ScorerId = 1
                        },
                        new
                        {
                            Id = 2,
                            FixtureId = 1,
                            IsOwnGoal = false,
                            IsPenalty = false,
                            MinuteScored = 50,
                            ScorerId = 2
                        },
                        new
                        {
                            Id = 3,
                            FixtureId = 2,
                            IsOwnGoal = false,
                            IsPenalty = false,
                            MinuteScored = 50,
                            ScorerId = 3
                        },
                        new
                        {
                            Id = 4,
                            FixtureId = 2,
                            IsOwnGoal = false,
                            IsPenalty = false,
                            MinuteScored = 50,
                            ScorerId = 4
                        });
                });

            modelBuilder.Entity("FootballScores.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2021, 12, 25, 12, 56, 7, 845, DateTimeKind.Local).AddTicks(6424),
                            Name = "La Liga",
                            StartDate = new DateTime(2021, 6, 8, 12, 56, 7, 843, DateTimeKind.Local).AddTicks(3739)
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2021, 12, 25, 12, 56, 7, 846, DateTimeKind.Local).AddTicks(283),
                            Name = "Premier League",
                            StartDate = new DateTime(2021, 6, 8, 12, 56, 7, 846, DateTimeKind.Local).AddTicks(268)
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2021, 12, 25, 12, 56, 7, 846, DateTimeKind.Local).AddTicks(292),
                            Name = "Ligue 1",
                            StartDate = new DateTime(2021, 6, 8, 12, 56, 7, 846, DateTimeKind.Local).AddTicks(290)
                        });
                });

            modelBuilder.Entity("FootballScores.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Assists = 1,
                            FirstName = "Marcelo",
                            LastName = "Aveiro",
                            Position = "LB",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Assists = 1,
                            FirstName = "Karim",
                            LastName = "Benzema",
                            Position = "CF",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            Assists = 1,
                            FirstName = "Lionel",
                            LastName = "Messi",
                            Position = "CF",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 4,
                            Assists = 0,
                            FirstName = "Sergio",
                            LastName = "Burgos",
                            Position = "MF",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 5,
                            Assists = 1,
                            FirstName = "Paul",
                            LastName = "Pogba",
                            Position = "MF",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 6,
                            Assists = 1,
                            FirstName = "Bruno",
                            LastName = "Fernandes",
                            Position = "MF",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 7,
                            Assists = 1,
                            FirstName = "Phil",
                            LastName = "Phoden",
                            Position = "MF",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 8,
                            Assists = 0,
                            FirstName = "Raheem",
                            LastName = "Sterling",
                            Position = "MF",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 9,
                            Assists = 1,
                            FirstName = "Angel",
                            LastName = "DiMaria",
                            Position = "MF",
                            TeamId = 5
                        },
                        new
                        {
                            Id = 10,
                            Assists = 1,
                            FirstName = "Kylian",
                            LastName = "Mbappe",
                            Position = "MF",
                            TeamId = 5
                        },
                        new
                        {
                            Id = 11,
                            Assists = 1,
                            FirstName = "Lukas",
                            LastName = "Paqueta",
                            Position = "MF",
                            TeamId = 6
                        },
                        new
                        {
                            Id = 12,
                            Assists = 1,
                            FirstName = "Bruno",
                            LastName = "Gimaraesh",
                            Position = "MF",
                            TeamId = 6
                        });
                });

            modelBuilder.Entity("FootballScores.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GoalsConceded")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Madrid",
                            Country = "Spain",
                            GoalsConceded = 0,
                            GoalsScored = 3,
                            LeagueId = 1,
                            Manager = "Carlo",
                            Name = "Real Madrid",
                            Points = 0
                        },
                        new
                        {
                            Id = 2,
                            City = "Barcelona",
                            Country = "Spain",
                            GoalsConceded = 2,
                            GoalsScored = 2,
                            LeagueId = 1,
                            Manager = "Ronald Koeman",
                            Name = "Barcelona",
                            Points = 0
                        },
                        new
                        {
                            Id = 3,
                            City = "Macnchester",
                            Country = "England",
                            GoalsConceded = 0,
                            GoalsScored = 3,
                            LeagueId = 2,
                            Manager = "Ole Gunar",
                            Name = "Manchester United",
                            Points = 0
                        },
                        new
                        {
                            Id = 4,
                            City = "Manchester",
                            Country = "England",
                            GoalsConceded = 2,
                            GoalsScored = 2,
                            LeagueId = 2,
                            Manager = "Pep Guardiola",
                            Name = "Manchester City",
                            Points = 0
                        },
                        new
                        {
                            Id = 5,
                            City = "Paris",
                            Country = "France",
                            GoalsConceded = 0,
                            GoalsScored = 3,
                            LeagueId = 3,
                            Manager = "Pochettino",
                            Name = "PSG",
                            Points = 0
                        },
                        new
                        {
                            Id = 6,
                            City = "Lyon",
                            Country = "France",
                            GoalsConceded = 2,
                            GoalsScored = 2,
                            LeagueId = 3,
                            Manager = "Rudy Garcia",
                            Name = "Lyon",
                            Points = 0
                        });
                });

            modelBuilder.Entity("FootballScores.Models.Fixture", b =>
                {
                    b.HasOne("FootballScores.Models.Team", "AwayTeam")
                        .WithMany("AwayFixtures")
                        .HasForeignKey("AwayTeamId")
                        .IsRequired();

                    b.HasOne("FootballScores.Models.Team", "HostTeam")
                        .WithMany("HostFixtures")
                        .HasForeignKey("HostTeamId")
                        .IsRequired();

                    b.HasOne("FootballScores.Models.League", "League")
                        .WithMany("Fixtures")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("FootballScores.Models.Statistic", "Statistic", b1 =>
                        {
                            b1.Property<int>("FixtureId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("AwayTeamCornerKicks")
                                .HasColumnType("int");

                            b1.Property<int>("AwayTeamFouls")
                                .HasColumnType("int");

                            b1.Property<int>("AwayTeamOffsides")
                                .HasColumnType("int");

                            b1.Property<int>("AwayTeamPossession")
                                .HasColumnType("int");

                            b1.Property<int>("AwayTeamShotsOffTarget")
                                .HasColumnType("int");

                            b1.Property<int>("AwayTeamShotsOnTarget")
                                .HasColumnType("int");

                            b1.Property<int>("HostTeamCornerKicks")
                                .HasColumnType("int");

                            b1.Property<int>("HostTeamFouls")
                                .HasColumnType("int");

                            b1.Property<int>("HostTeamOffsides")
                                .HasColumnType("int");

                            b1.Property<int>("HostTeamPossession")
                                .HasColumnType("int");

                            b1.Property<int>("HostTeamShotsOffTarget")
                                .HasColumnType("int");

                            b1.Property<int>("HostTeamShotsOnTarget")
                                .HasColumnType("int");

                            b1.HasKey("FixtureId");

                            b1.ToTable("Fixtures");

                            b1.WithOwner()
                                .HasForeignKey("FixtureId");

                            b1.HasData(
                                new
                                {
                                    FixtureId = 1,
                                    AwayTeamCornerKicks = 5,
                                    AwayTeamFouls = 11,
                                    AwayTeamOffsides = 10,
                                    AwayTeamPossession = 40,
                                    AwayTeamShotsOffTarget = 6,
                                    AwayTeamShotsOnTarget = 5,
                                    HostTeamCornerKicks = 2,
                                    HostTeamFouls = 4,
                                    HostTeamOffsides = 3,
                                    HostTeamPossession = 60,
                                    HostTeamShotsOffTarget = 2,
                                    HostTeamShotsOnTarget = 1
                                },
                                new
                                {
                                    FixtureId = 2,
                                    AwayTeamCornerKicks = 5,
                                    AwayTeamFouls = 11,
                                    AwayTeamOffsides = 10,
                                    AwayTeamPossession = 40,
                                    AwayTeamShotsOffTarget = 6,
                                    AwayTeamShotsOnTarget = 5,
                                    HostTeamCornerKicks = 2,
                                    HostTeamFouls = 4,
                                    HostTeamOffsides = 3,
                                    HostTeamPossession = 60,
                                    HostTeamShotsOffTarget = 2,
                                    HostTeamShotsOnTarget = 1
                                },
                                new
                                {
                                    FixtureId = 3,
                                    AwayTeamCornerKicks = 5,
                                    AwayTeamFouls = 11,
                                    AwayTeamOffsides = 10,
                                    AwayTeamPossession = 40,
                                    AwayTeamShotsOffTarget = 6,
                                    AwayTeamShotsOnTarget = 5,
                                    HostTeamCornerKicks = 2,
                                    HostTeamFouls = 4,
                                    HostTeamOffsides = 3,
                                    HostTeamPossession = 60,
                                    HostTeamShotsOffTarget = 2,
                                    HostTeamShotsOnTarget = 1
                                });
                        });

                    b.Navigation("AwayTeam");

                    b.Navigation("HostTeam");

                    b.Navigation("League");

                    b.Navigation("Statistic");
                });

            modelBuilder.Entity("FootballScores.Models.Goal", b =>
                {
                    b.HasOne("FootballScores.Models.Fixture", "Fixture")
                        .WithMany("Score")
                        .HasForeignKey("FixtureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballScores.Models.Player", "Scorer")
                        .WithMany("Goals")
                        .HasForeignKey("ScorerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fixture");

                    b.Navigation("Scorer");
                });

            modelBuilder.Entity("FootballScores.Models.Player", b =>
                {
                    b.HasOne("FootballScores.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FootballScores.Models.Team", b =>
                {
                    b.HasOne("FootballScores.Models.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("FootballScores.Models.Fixture", b =>
                {
                    b.Navigation("Score");
                });

            modelBuilder.Entity("FootballScores.Models.League", b =>
                {
                    b.Navigation("Fixtures");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("FootballScores.Models.Player", b =>
                {
                    b.Navigation("Goals");
                });

            modelBuilder.Entity("FootballScores.Models.Team", b =>
                {
                    b.Navigation("AwayFixtures");

                    b.Navigation("HostFixtures");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
