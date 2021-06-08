﻿// <auto-generated />
using System;
using FootballScores.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FootballScores.Data.Migrations
{
    [DbContext(typeof(FootballStatsDbContext))]
    [Migration("20210608094710_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
