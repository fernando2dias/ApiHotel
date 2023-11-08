using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class fixreview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("e8461be0-3d56-4a00-8c39-3c9eb3baac38"), new DateTime(1986, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "111.222.333-44", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5083), "fernando3dias@gmail.com", "Dias Motta", "Fernando", null, "123mudar", null, new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("44196009-4f45-4a31-953c-f080ac7cb435"), "Praça Principal, 654", 280m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5119), "The Grand Plaza Hotel", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5120), "23456-789" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("4e2d50ba-d1e7-4a0d-8956-ac45ec12cc61"), "Trilha da Montanha, 765", 190m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5135), "Mountain View Lodge", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5135), "65432-123" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("5ceda157-fac3-4720-9c11-5f2535c122cb"), "Rua das Flores, 456", 120m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5107), "Cozy Inn", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5108), "54321-987" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("5dd2e94e-1a17-4a7b-a21f-ce4deda1df65"), "Praia da Areia Dourada, S/N", 300m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5112), "Golden Sands Resort", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5113), "34567-890" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("9d46bbdf-3dab-401f-a12c-5ce334014f35"), "Margem do Rio, 987", 160m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5116), "Riverside Lodge", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5116), "76543-210" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("a4bbcb28-1315-4624-b6d1-51163021da75"), "Avenida Central, 876", 130m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5128), "Sorocaba Suites", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5128), "12345-543" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("a4ca3f74-7e0e-4945-8ba6-faee2059b0a6"), "Avenida das Estrelas, 123", 250m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5105), "Luxury Palace Hotel", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5105), "12345-678" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("d304a6ce-f2dc-4a71-81a6-6fc294ac2b63"), "Avenida do Pôr do Sol, 321", 140m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5122), "Sunset View Inn", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5123), "87654-321" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("e9205ef5-1311-4d09-bf13-f92288569ca2"), "Rodovia Senador José Ermírio de Moraes, 1425", 150m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5102), "Facens Hotel", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5103), "18085-784" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("ec1fb76d-2a23-4479-9ae7-d11ae8d49830"), "Rua das Montanhas, 567", 200m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5125), "Majestic Heights Hotel", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5126), "54321-234" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("f34d322f-f5dc-41d9-ada9-c10ed23fd4d3"), "Avenida Beira-Mar, 789", 180m, "Sorocaba", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5110), "Harbor View Hotel", "SP", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(5110), "98765-432" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("7ef52675-e2e7-40ff-b6dd-ef1a481ffbb5"), new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(4849), "fer@admin.com.br", "Administrador", new DateTime(2023, 11, 8, 20, 12, 13, 481, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("024a0c0f-3f06-41f1-9cca-a29f16edd7d2"), null, new Guid("a4ca3f74-7e0e-4945-8ba6-faee2059b0a6"), 37, 1, 177m, 1, 4, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("7628fad8-1cdd-4e65-8167-006363730082"), null, new Guid("f34d322f-f5dc-41d9-ada9-c10ed23fd4d3"), 5, 1, 179m, 1, 3, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("7ced0558-1f3b-4376-94ad-72f4f5d910f5"), null, new Guid("5ceda157-fac3-4720-9c11-5f2535c122cb"), 64, 1, 172m, 1, 11, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("9289104f-83a6-4746-b299-f71424137359"), null, new Guid("5ceda157-fac3-4720-9c11-5f2535c122cb"), 18, 1, 129m, 1, 11, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("b092fde0-eb05-4fbd-bf61-cace5e902545"), null, new Guid("f34d322f-f5dc-41d9-ada9-c10ed23fd4d3"), 83, 4, 80m, 1, 2, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("c7da17ef-6fdb-43da-b92c-8825830a9561"), null, new Guid("e9205ef5-1311-4d09-bf13-f92288569ca2"), 66, 1, 163m, 1, 6, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("d52239d9-fc0d-4c62-bde2-283977d1cec1"), null, new Guid("e9205ef5-1311-4d09-bf13-f92288569ca2"), 73, 3, 184m, 1, 3, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("d862683e-db14-4b82-a0a6-91178b900710"), null, new Guid("e9205ef5-1311-4d09-bf13-f92288569ca2"), 4, 3, 194m, 1, 3, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("df0370fd-f690-4733-9cff-0f487eec821c"), null, new Guid("a4ca3f74-7e0e-4945-8ba6-faee2059b0a6"), 28, 2, 103m, 1, 6, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("f15916e1-7e43-4f59-a138-87b65cf6d897"), null, new Guid("5ceda157-fac3-4720-9c11-5f2535c122cb"), 89, 2, 137m, 1, 9, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e8461be0-3d56-4a00-8c39-3c9eb3baac38"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("44196009-4f45-4a31-953c-f080ac7cb435"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("4e2d50ba-d1e7-4a0d-8956-ac45ec12cc61"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("5dd2e94e-1a17-4a7b-a21f-ce4deda1df65"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("9d46bbdf-3dab-401f-a12c-5ce334014f35"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("a4bbcb28-1315-4624-b6d1-51163021da75"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("d304a6ce-f2dc-4a71-81a6-6fc294ac2b63"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("ec1fb76d-2a23-4479-9ae7-d11ae8d49830"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("024a0c0f-3f06-41f1-9cca-a29f16edd7d2"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("7628fad8-1cdd-4e65-8167-006363730082"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("7ced0558-1f3b-4376-94ad-72f4f5d910f5"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("9289104f-83a6-4746-b299-f71424137359"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("b092fde0-eb05-4fbd-bf61-cace5e902545"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("c7da17ef-6fdb-43da-b92c-8825830a9561"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("d52239d9-fc0d-4c62-bde2-283977d1cec1"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("d862683e-db14-4b82-a0a6-91178b900710"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("df0370fd-f690-4733-9cff-0f487eec821c"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("f15916e1-7e43-4f59-a138-87b65cf6d897"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7ef52675-e2e7-40ff-b6dd-ef1a481ffbb5"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("5ceda157-fac3-4720-9c11-5f2535c122cb"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("a4ca3f74-7e0e-4945-8ba6-faee2059b0a6"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("e9205ef5-1311-4d09-bf13-f92288569ca2"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("f34d322f-f5dc-41d9-ada9-c10ed23fd4d3"));

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
    }
}
