using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace JOIN.Migrations
{
    public partial class removedemailclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_EmailAddress_ValidEmailId",
                table: "Registrations");

            migrationBuilder.DropTable(
                name: "EmailAddress");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_ValidEmailId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "ValidEmailId",
                table: "Registrations");

            migrationBuilder.AddColumn<string>(
                name: "ValidEmail",
                table: "Registrations",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidEmail",
                table: "Registrations");

            migrationBuilder.AddColumn<int>(
                name: "ValidEmailId",
                table: "Registrations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmailAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ValidEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddress", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ValidEmailId",
                table: "Registrations",
                column: "ValidEmailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_EmailAddress_ValidEmailId",
                table: "Registrations",
                column: "ValidEmailId",
                principalTable: "EmailAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
