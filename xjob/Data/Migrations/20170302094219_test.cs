using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xjob.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.EnsureSchema(
                name: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newSchema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newSchema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newSchema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newSchema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newSchema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newSchema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newSchema: "koddelning");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePic",
                schema: "koddelning",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "koddelning",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                schema: "koddelning",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                schema: "koddelning",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "koddelning");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "koddelning");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
