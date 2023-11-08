using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class fixroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("df30e81b-3e55-4898-9261-b02b5a6e621c"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("176f09ec-348a-42ca-a708-68edb1a8b3c5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e2ad35c5-6b3b-45f4-aac0-03f88ef59184"));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "BirthDate", "CPF", "CreateAt", "Email", "LastName", "Name", "Passport", "Password", "RG", "UpdateAt" },
                values: new object[] { new Guid("77c26104-e04b-475e-8c3e-de230132f1d3"), new DateTime(1986, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "111.222.333-44", new DateTime(2023, 11, 7, 22, 24, 30, 308, DateTimeKind.Local).AddTicks(6395), "fernando3dias@gmail.com", "Dias Motta", "Fernando", null, "123mudar", null, new DateTime(2023, 11, 7, 22, 24, 30, 308, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("a9b8c046-9ca0-4de0-a644-8ab45167b48b"), "Rodovia Senador José Ermírio de Moraes, 1425", 150m, "Sorocaba", new DateTime(2023, 11, 7, 22, 24, 30, 308, DateTimeKind.Local).AddTicks(6440), "Facens Hotel", "SP", new DateTime(2023, 11, 7, 22, 24, 30, 308, DateTimeKind.Local).AddTicks(6441), "18085-784" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("5b31ab57-3d4f-4c19-bd50-7b96de7c1bb6"), new DateTime(2023, 11, 7, 22, 24, 30, 308, DateTimeKind.Local).AddTicks(5929), "fer@admin.com.br", "Administrador", new DateTime(2023, 11, 7, 22, 24, 30, 308, DateTimeKind.Local).AddTicks(5946) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("77c26104-e04b-475e-8c3e-de230132f1d3"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("a9b8c046-9ca0-4de0-a644-8ab45167b48b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5b31ab57-3d4f-4c19-bd50-7b96de7c1bb6"));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "BirthDate", "CPF", "CreateAt", "Email", "LastName", "Name", "Passport", "Password", "RG", "UpdateAt" },
                values: new object[] { new Guid("df30e81b-3e55-4898-9261-b02b5a6e621c"), new DateTime(1986, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "111.222.333-44", new DateTime(2023, 11, 7, 21, 14, 28, 293, DateTimeKind.Local).AddTicks(4217), "fernando3dias@gmail.com", "Dias Motta", "Fernando", null, "123mudar", null, new DateTime(2023, 11, 7, 21, 14, 28, 293, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("176f09ec-348a-42ca-a708-68edb1a8b3c5"), "Rodovia Senador José Ermírio de Moraes, 1425", 150m, "Sorocaba", new DateTime(2023, 11, 7, 21, 14, 28, 293, DateTimeKind.Local).AddTicks(4238), "Facens Hotel", "SP", new DateTime(2023, 11, 7, 21, 14, 28, 293, DateTimeKind.Local).AddTicks(4239), "18085-784" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("e2ad35c5-6b3b-45f4-aac0-03f88ef59184"), new DateTime(2023, 11, 7, 21, 14, 28, 293, DateTimeKind.Local).AddTicks(3891), "fer@admin.com.br", "Administrador", new DateTime(2023, 11, 7, 21, 14, 28, 293, DateTimeKind.Local).AddTicks(3909) });
        }
    }
}
