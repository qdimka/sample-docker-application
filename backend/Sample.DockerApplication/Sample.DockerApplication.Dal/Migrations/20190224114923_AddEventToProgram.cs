using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample.DockerApplication.Dal.Migrations
{
    public partial class AddEventToProgram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventPrograms_EventProgramId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Presentations_EventPrograms_EventProgramId",
                table: "Presentations");

            migrationBuilder.DropTable(
                name: "EventPrograms");

            migrationBuilder.DropIndex(
                name: "IX_Presentations_EventProgramId",
                table: "Presentations");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventProgramId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventProgramId",
                table: "Presentations");

            migrationBuilder.DropColumn(
                name: "EventProgramId",
                table: "Events");

            migrationBuilder.AddColumn<long>(
                name: "EventId",
                table: "Presentations",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventId",
                value: 3L);

            migrationBuilder.CreateIndex(
                name: "IX_Presentations_EventId",
                table: "Presentations",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Presentations_Events_EventId",
                table: "Presentations",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presentations_Events_EventId",
                table: "Presentations");

            migrationBuilder.DropIndex(
                name: "IX_Presentations_EventId",
                table: "Presentations");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Presentations");

            migrationBuilder.AddColumn<long>(
                name: "EventProgramId",
                table: "Presentations",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "EventProgramId",
                table: "Events",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "EventPrograms",
                column: "Id",
                value: 1L);

            migrationBuilder.InsertData(
                table: "EventPrograms",
                column: "Id",
                value: 2L);

            migrationBuilder.InsertData(
                table: "EventPrograms",
                column: "Id",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventProgramId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventProgramId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventProgramId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventProgramId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventProgramId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventProgramId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventProgramId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventProgramId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventProgramId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventProgramId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventProgramId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventProgramId",
                value: 3L);

            migrationBuilder.CreateIndex(
                name: "IX_Presentations_EventProgramId",
                table: "Presentations",
                column: "EventProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventProgramId",
                table: "Events",
                column: "EventProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventPrograms_EventProgramId",
                table: "Events",
                column: "EventProgramId",
                principalTable: "EventPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Presentations_EventPrograms_EventProgramId",
                table: "Presentations",
                column: "EventProgramId",
                principalTable: "EventPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
