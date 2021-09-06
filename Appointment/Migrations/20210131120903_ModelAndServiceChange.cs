using Microsoft.EntityFrameworkCore.Migrations;

namespace Appointment_UI.Migrations
{
    public partial class ModelAndServiceChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Appointments_DateId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Appointments_AppointmentsId",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentsId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentsDurationInMinits",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Appointments",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentDuration",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Appointments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Appointments_DateId",
                table: "Dates",
                column: "DateId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Appointments_AppointmentsId",
                table: "Services",
                column: "AppointmentsId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Appointments_DateId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Appointments_AppointmentsId",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentDuration",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentsId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentsDurationInMinits",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "AppointmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Appointments_DateId",
                table: "Dates",
                column: "DateId",
                principalTable: "Appointments",
                principalColumn: "AppointmentsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Appointments_AppointmentsId",
                table: "Services",
                column: "AppointmentsId",
                principalTable: "Appointments",
                principalColumn: "AppointmentsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
