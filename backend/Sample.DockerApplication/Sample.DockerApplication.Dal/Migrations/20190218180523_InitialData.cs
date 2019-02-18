using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample.DockerApplication.Dal.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Presentations",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Presentations",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.InsertData(
                table: "EventPrograms",
                column: "Id",
                value: 1L);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventProgramId", "ImageLink", "IsRegistrationOpen", "StartDate", "Title" },
                values: new object[] { 1L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 1L, null, false, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Technology Conference" });

            migrationBuilder.InsertData(
                table: "Presentations",
                columns: new[] { "Id", "Author", "Company", "EndTime", "EventProgramId", "StartTime", "Title" },
                values: new object[,]
                {
                    { 1L, "John Smith", "VeryCoolCompany Inc.", new TimeSpan(0, 12, 0, 0, 0), 1L, new TimeSpan(0, 10, 0, 0, 0), "A quick guide to help you understand and create ReactJS apps" },
                    { 2L, "Robert Johnson", "BigCompany Inc.", new TimeSpan(0, 14, 0, 0, 0), 1L, new TimeSpan(0, 12, 0, 0, 0), "ASP.NET Web Deployment using Visual Studio" },
                    { 3L, null, null, new TimeSpan(0, 15, 0, 0, 0), 1L, new TimeSpan(0, 14, 0, 0, 0), "Coffee" },
                    { 4L, "David Linthicum", "Deloitte Consulting", new TimeSpan(0, 17, 0, 0, 0), 1L, new TimeSpan(0, 15, 0, 0, 0), "Here are 9 effective best practices for using DevOps in the cloud" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "EventPrograms",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Presentations",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Presentations",
                nullable: false,
                oldClrType: typeof(TimeSpan));
        }
    }
}
