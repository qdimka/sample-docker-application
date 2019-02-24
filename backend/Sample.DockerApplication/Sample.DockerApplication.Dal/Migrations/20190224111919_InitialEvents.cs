using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample.DockerApplication.Dal.Migrations
{
    public partial class InitialEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventPrograms",
                column: "Id",
                value: 2L);

            migrationBuilder.InsertData(
                table: "EventPrograms",
                column: "Id",
                value: 3L);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventProgramId", "ImageLink", "IsRegistrationOpen", "StartDate", "Title" },
                values: new object[,]
                {
                    { 2L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris. ", 2L, "https://cdn-images-1.medium.com/max/2600/1*JAJ910fg52ODIRZjHXASBQ.png", false, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Docker meetup" },
                    { 3L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris. ", 3L, "https://pics.me.me/rubber-duck-debugging-the-rubber-duck-debugging-method-is-as-18277289.png", false, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Rubber duck debugging" }
                });

            migrationBuilder.InsertData(
                table: "Presentations",
                columns: new[] { "Id", "Author", "Company", "EndTime", "EventProgramId", "StartTime", "Title" },
                values: new object[,]
                {
                    { 5L, "John Smith", "VeryCoolCompany Inc.", new TimeSpan(0, 12, 0, 0, 0), 2L, new TimeSpan(0, 10, 0, 0, 0), "A quick guide to help you understand and create ReactJS apps" },
                    { 6L, "Robert Johnson", "BigCompany Inc.", new TimeSpan(0, 14, 0, 0, 0), 2L, new TimeSpan(0, 12, 0, 0, 0), "ASP.NET Web Deployment using Visual Studio" },
                    { 7L, null, null, new TimeSpan(0, 15, 0, 0, 0), 2L, new TimeSpan(0, 14, 0, 0, 0), "Coffee" },
                    { 8L, "David Linthicum", "Deloitte Consulting", new TimeSpan(0, 17, 0, 0, 0), 2L, new TimeSpan(0, 15, 0, 0, 0), "Here are 9 effective best practices for using DevOps in the cloud" },
                    { 9L, "Pragmatic Programmer", "Duck Factory", new TimeSpan(0, 15, 0, 0, 0), 3L, new TimeSpan(0, 10, 0, 0, 0), "Rubber duck and debug" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "EventPrograms",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "EventPrograms",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
