using Microsoft.EntityFrameworkCore.Migrations;

namespace SagTest.Migrations
{
    public partial class testmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Sag_SagSubjectId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_SagSubjectId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "SagSubjectId",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Sag",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SagFKId",
                table: "Images",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Images_SagFKId",
                table: "Images",
                column: "SagFKId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Sag_SagFKId",
                table: "Images",
                column: "SagFKId",
                principalTable: "Sag",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Sag_SagFKId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_SagFKId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Sag");

            migrationBuilder.DropColumn(
                name: "SagFKId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "SagSubjectId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_SagSubjectId",
                table: "Images",
                column: "SagSubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Sag_SagSubjectId",
                table: "Images",
                column: "SagSubjectId",
                principalTable: "Sag",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
