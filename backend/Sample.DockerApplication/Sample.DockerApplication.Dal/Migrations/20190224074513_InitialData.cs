using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample.DockerApplication.Dal.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventPrograms",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageLink = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    IsRegistrationOpen = table.Column<bool>(nullable: false),
                    EventProgramId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EventPrograms_EventProgramId",
                        column: x => x.EventProgramId,
                        principalTable: "EventPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Presentations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    EventProgramId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Presentations_EventPrograms_EventProgramId",
                        column: x => x.EventProgramId,
                        principalTable: "EventPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "EventPrograms",
                column: "Id",
                value: 1L);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventProgramId", "ImageLink", "IsRegistrationOpen", "StartDate", "Title" },
                values: new object[] { 1L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris. ", 1L, "https://digital.report/wp-content/uploads/2017/04/615124073-1078x516.jpg", false, new DateTime(2019, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Technology Conference" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventProgramId",
                table: "Events",
                column: "EventProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Presentations_EventProgramId",
                table: "Presentations",
                column: "EventProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Presentations");

            migrationBuilder.DropTable(
                name: "EventPrograms");
        }
    }
}
