using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class fixreview2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Customer_CustomerId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Hotel_HotelId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_CustomerId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_HotelId",
                table: "Review");

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
                values: new object[] { new Guid("25b6c777-4a13-4004-952b-bfddf66caa9c"), new DateTime(1986, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "111.222.333-44", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7588), "fernando3dias@gmail.com", "Dias Motta", "Fernando", null, "123mudar", null, new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("0cf96aeb-36d7-4432-ace3-833449a2769b"), "Rua das Montanhas, 567", 200m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7649), "Majestic Heights Hotel", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7649), "54321-234" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("1d87ad36-bcbd-4181-8405-bedb13e6d952"), "Avenida das Estrelas, 123", 250m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7604), "Luxury Palace Hotel", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7605), "12345-678" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("337388f1-3da4-4e30-88a1-caf45fb78447"), "Avenida Beira-Mar, 789", 180m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7608), "Harbor View Hotel", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7609), "98765-432" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("6842b955-7eda-430a-b40d-d66b8f49d189"), "Avenida Central, 876", 130m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7651), "Sorocaba Suites", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7652), "12345-543" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("6f134138-26e8-4485-be91-6ce45e37fa4f"), "Rodovia Senador José Ermírio de Moraes, 1425", 150m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7602), "Facens Hotel", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7603), "18085-784" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("6fd229f6-a963-403e-9497-e938c0866642"), "Praça Principal, 654", 280m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7645), "The Grand Plaza Hotel", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7645), "23456-789" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("7c4aa550-3a37-4b36-ae37-5ad929a7b007"), "Avenida do Pôr do Sol, 321", 140m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7647), "Sunset View Inn", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7647), "87654-321" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"), "Rua das Flores, 456", 120m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7606), "Cozy Inn", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7607), "54321-987" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("cc6ed24a-fb03-42cb-9c54-4dc29c3cbaaf"), "Praia da Areia Dourada, S/N", 300m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7610), "Golden Sands Resort", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7610), "34567-890" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("eadceebe-8411-45b5-9cab-df11d5133e40"), "Margem do Rio, 987", 160m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7612), "Riverside Lodge", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7612), "76543-210" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("fca839a5-7e7c-418d-aeb4-a43e25ffa9b1"), "Trilha da Montanha, 765", 190m, "Sorocaba", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7653), "Mountain View Lodge", "SP", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7654), "65432-123" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("32dbe5c4-4b77-4b1e-808c-fb104e4e88ff"), new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7423), "fer@admin.com.br", "Administrador", new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("077ac67d-3a91-48be-a718-9f3682cd2df9"), null, new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"), 64, 1, 84m, 1, 7, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("13301f3c-c3c6-4cee-8023-f075986b9327"), null, new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"), 1, 2, 161m, 1, 8, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("37356558-4658-4831-b19a-a3492952b795"), null, new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"), 2, 3, 107m, 1, 10, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("3c727f96-e7ca-45ae-a742-85691d74a361"), null, new Guid("6f134138-26e8-4485-be91-6ce45e37fa4f"), 24, 2, 163m, 1, 5, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("41470ba6-dec4-4ed6-bbea-e659c2f72c8c"), null, new Guid("337388f1-3da4-4e30-88a1-caf45fb78447"), 25, 2, 152m, 1, 2, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("57508cef-9d2b-4f88-9c65-fa977a496056"), null, new Guid("1d87ad36-bcbd-4181-8405-bedb13e6d952"), 16, 3, 196m, 1, 8, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("62a08296-56c0-483c-881a-61a2bda8784b"), null, new Guid("1d87ad36-bcbd-4181-8405-bedb13e6d952"), 10, 1, 190m, 1, 4, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("876c663c-1ddb-4330-906f-0452dd11ad43"), null, new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"), 32, 1, 188m, 1, 6, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("a2b9d2f4-982c-4c99-a73e-3aa9810987dd"), null, new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"), 34, 3, 125m, 1, 5, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("f30b1862-32bc-4587-a491-86b2e960e86f"), null, new Guid("6f134138-26e8-4485-be91-6ce45e37fa4f"), 63, 1, 189m, 1, 3, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("25b6c777-4a13-4004-952b-bfddf66caa9c"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("0cf96aeb-36d7-4432-ace3-833449a2769b"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("6842b955-7eda-430a-b40d-d66b8f49d189"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("6fd229f6-a963-403e-9497-e938c0866642"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7c4aa550-3a37-4b36-ae37-5ad929a7b007"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("cc6ed24a-fb03-42cb-9c54-4dc29c3cbaaf"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("eadceebe-8411-45b5-9cab-df11d5133e40"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("fca839a5-7e7c-418d-aeb4-a43e25ffa9b1"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("077ac67d-3a91-48be-a718-9f3682cd2df9"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("13301f3c-c3c6-4cee-8023-f075986b9327"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("37356558-4658-4831-b19a-a3492952b795"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("3c727f96-e7ca-45ae-a742-85691d74a361"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("41470ba6-dec4-4ed6-bbea-e659c2f72c8c"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("57508cef-9d2b-4f88-9c65-fa977a496056"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("62a08296-56c0-483c-881a-61a2bda8784b"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("876c663c-1ddb-4330-906f-0452dd11ad43"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("a2b9d2f4-982c-4c99-a73e-3aa9810987dd"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("f30b1862-32bc-4587-a491-86b2e960e86f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("32dbe5c4-4b77-4b1e-808c-fb104e4e88ff"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("1d87ad36-bcbd-4181-8405-bedb13e6d952"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("337388f1-3da4-4e30-88a1-caf45fb78447"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("6f134138-26e8-4485-be91-6ce45e37fa4f"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Review_CustomerId",
                table: "Review",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_HotelId",
                table: "Review",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Customer_CustomerId",
                table: "Review",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Hotel_HotelId",
                table: "Review",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
