using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace JOIN.Migrations
{
    public partial class fixedmodelbind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_EmailAddress_EmailId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_EmailId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Registrations");

            migrationBuilder.RenameColumn(
                name: "ValidAddress",
                table: "EmailAddress",
                newName: "ValidEmail");

            migrationBuilder.AddColumn<int>(
                name: "ValidEmailId",
                table: "Registrations",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_EmailAddress_ValidEmailId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_ValidEmailId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "ValidEmailId",
                table: "Registrations");

            migrationBuilder.RenameColumn(
                name: "ValidEmail",
                table: "EmailAddress",
                newName: "ValidAddress");

            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "Registrations",
                nullable: false,
                defaultValue: 0);

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
    }
}
