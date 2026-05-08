using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AITech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeamMemberId",
                table: "TeamMembers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeamHeaderId",
                table: "TeamHeaders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NewsletterId",
                table: "Newsletters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ContactMessageId",
                table: "ContactMessages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ContactInfoId",
                table: "ContactInfos",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TeamMembers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "TeamMembers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TeamHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "TeamHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Newsletters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Newsletters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ContactMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ContactMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TeamHeaders");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "TeamHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Newsletters");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Newsletters");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ContactMessages");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ContactMessages");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ContactInfos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TeamMembers",
                newName: "TeamMemberId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TeamHeaders",
                newName: "TeamHeaderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Newsletters",
                newName: "NewsletterId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ContactMessages",
                newName: "ContactMessageId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ContactInfos",
                newName: "ContactInfoId");
        }
    }
}
