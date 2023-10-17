using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blood_Donor_Portal.Data.Migrations
{
    public partial class UpdateBloodCampModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "BloodCamp",
                newName: "StartTime");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "BloodCamp",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "BloodCamp");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "BloodCamp",
                newName: "Time");
        }
    }
}
