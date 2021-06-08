using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballScores.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { 1, new DateTime(2021, 12, 25, 12, 56, 7, 845, DateTimeKind.Local).AddTicks(6424), "La Liga", new DateTime(2021, 6, 8, 12, 56, 7, 843, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { 2, new DateTime(2021, 12, 25, 12, 56, 7, 846, DateTimeKind.Local).AddTicks(283), "Premier League", new DateTime(2021, 6, 8, 12, 56, 7, 846, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { 3, new DateTime(2021, 12, 25, 12, 56, 7, 846, DateTimeKind.Local).AddTicks(292), "Ligue 1", new DateTime(2021, 6, 8, 12, 56, 7, 846, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Country", "GoalsConceded", "GoalsScored", "LeagueId", "Manager", "Name", "Points" },
                values: new object[,]
                {
                    { 1, "Madrid", "Spain", 0, 3, 1, "Carlo", "Real Madrid", 0 },
                    { 2, "Barcelona", "Spain", 2, 2, 1, "Ronald Koeman", "Barcelona", 0 },
                    { 3, "Macnchester", "England", 0, 3, 2, "Ole Gunar", "Manchester United", 0 },
                    { 4, "Manchester", "England", 2, 2, 2, "Pep Guardiola", "Manchester City", 0 },
                    { 5, "Paris", "France", 0, 3, 3, "Pochettino", "PSG", 0 },
                    { 6, "Lyon", "France", 2, 2, 3, "Rudy Garcia", "Lyon", 0 }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "GameDate", "HostTeamId", "LeagueId", "Referee", "Venue", "Statistic_AwayTeamCornerKicks", "Statistic_AwayTeamFouls", "Statistic_AwayTeamOffsides", "Statistic_AwayTeamPossession", "Statistic_AwayTeamShotsOffTarget", "Statistic_AwayTeamShotsOnTarget", "Statistic_HostTeamCornerKicks", "Statistic_HostTeamFouls", "Statistic_HostTeamOffsides", "Statistic_HostTeamPossession", "Statistic_HostTeamShotsOffTarget", "Statistic_HostTeamShotsOnTarget" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2021, 6, 8, 12, 56, 7, 848, DateTimeKind.Local).AddTicks(6452), 1, 1, "Soza", "Bernabeu", 5, 11, 10, 40, 6, 5, 2, 4, 3, 60, 2, 1 },
                    { 2, 4, new DateTime(2021, 6, 8, 12, 56, 7, 850, DateTimeKind.Local).AddTicks(1700), 3, 2, "Mark Clattenberg", "Old Traford", 5, 11, 10, 40, 6, 5, 2, 4, 3, 60, 2, 1 },
                    { 3, 6, new DateTime(2021, 6, 8, 12, 56, 7, 850, DateTimeKind.Local).AddTicks(5900), 5, 3, "Jan Pam", "PSG Arena", 5, 11, 10, 40, 6, 5, 2, 4, 3, 60, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Assists", "FirstName", "LastName", "Position", "TeamId" },
                values: new object[,]
                {
                    { 1, 1, "Marcelo", "Aveiro", "LB", 1 },
                    { 2, 1, "Karim", "Benzema", "CF", 1 },
                    { 3, 1, "Lionel", "Messi", "CF", 2 },
                    { 4, 0, "Sergio", "Burgos", "MF", 2 },
                    { 5, 1, "Paul", "Pogba", "MF", 3 },
                    { 6, 1, "Bruno", "Fernandes", "MF", 3 },
                    { 7, 1, "Phil", "Phoden", "MF", 4 },
                    { 8, 0, "Raheem", "Sterling", "MF", 4 },
                    { 9, 1, "Angel", "DiMaria", "MF", 5 },
                    { 10, 1, "Kylian", "Mbappe", "MF", 5 },
                    { 11, 1, "Lukas", "Paqueta", "MF", 6 },
                    { 12, 1, "Bruno", "Gimaraesh", "MF", 6 }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "FixtureId", "IsOwnGoal", "IsPenalty", "MinuteScored", "ScorerId" },
                values: new object[,]
                {
                    { 1, 1, false, false, 10, 1 },
                    { 2, 1, false, false, 50, 2 },
                    { 3, 2, false, false, 50, 3 },
                    { 4, 2, false, false, 50, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
