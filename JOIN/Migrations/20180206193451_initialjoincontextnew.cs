using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace JOIN.Migrations
{
    public partial class initialjoincontextnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "Registrations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Registrations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmailAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ValidAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddress", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_EmailId",
                table: "Registrations",
                column: "EmailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_EmailAddress_EmailId",
                table: "Registrations",
                column: "EmailId",
                principalTable: "EmailAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_EmailAddress_EmailId",
                table: "Registrations");

            migrationBuilder.DropTable(
                name: "EmailAddress");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_EmailId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Registrations");
        }
    }
}
