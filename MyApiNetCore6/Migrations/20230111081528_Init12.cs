using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiNetCore6.Migrations
{
    public partial class Init12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Size");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Make");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BodyType");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Size",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Make",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BodyType",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Size",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Make",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "BodyType",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "id",
                keyValue: 1,
                column: "code",
                value: "Coupe");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "id",
                keyValue: 2,
                column: "code",
                value: "Sedan");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "id",
                keyValue: 3,
                column: "code",
                value: "Hatchback");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "id",
                keyValue: 4,
                column: "code",
                value: "Wagon");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "id",
                keyValue: 5,
                column: "code",
                value: "Convertible");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "id",
                keyValue: 6,
                column: "code",
                value: "SUV");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "id",
                keyValue: 7,
                column: "code",
                value: "Truck");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "id",
                keyValue: 8,
                column: "code",
                value: "Mini Van");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "id",
                keyValue: 9,
                column: "code",
                value: "Roadster");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "id",
                keyValue: 1,
                column: "code",
                value: "Subcompact");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "id",
                keyValue: 2,
                column: "code",
                value: "Compact");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "id",
                keyValue: 3,
                column: "code",
                value: "Mid Size");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "id",
                keyValue: 5,
                column: "code",
                value: "Full Size");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "Size");

            migrationBuilder.DropColumn(
                name: "code",
                table: "Make");

            migrationBuilder.DropColumn(
                name: "code",
                table: "BodyType");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Size",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Make",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "BodyType",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Size",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Make",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BodyType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Coupe");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Sedan");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Hatchback");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Wagon");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Convertible");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "SUV");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Truck");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Mini Van");

            migrationBuilder.UpdateData(
                table: "BodyType",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Roadster");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Subcompact");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Compact");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Mid Size");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Full Size");
        }
    }
}
