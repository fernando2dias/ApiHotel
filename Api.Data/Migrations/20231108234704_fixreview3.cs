using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class fixreview3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("0d3b57e8-55ae-405c-b0de-2f30e1288b06"), new DateTime(1986, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "111.222.333-44", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(406), "fernando3dias@gmail.com", "Dias Motta", "Fernando", null, "123mudar", null, new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("03158875-1b25-4844-81f4-8fe88147d56b"), "Praia da Areia Dourada, S/N", 300m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(427), "Golden Sands Resort", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(427), "34567-890" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("2045987e-853c-4fec-9c4e-4813347e044b"), "Avenida do Pôr do Sol, 321", 140m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(432), "Sunset View Inn", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(433), "87654-321" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("86faabfb-21b8-4eca-a999-db074e489e37"), "Rodovia Senador José Ermírio de Moraes, 1425", 150m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(420), "Facens Hotel", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(420), "18085-784" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("8dc27776-7086-426c-9657-a4f3ebf3c336"), "Rua das Montanhas, 567", 200m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(434), "Majestic Heights Hotel", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(434), "54321-234" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("98a51d43-35d0-495b-9932-c62311f4b130"), "Praça Principal, 654", 280m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(430), "The Grand Plaza Hotel", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(431), "23456-789" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("9fe39e98-4bdd-482a-b835-7b6616a9665d"), "Margem do Rio, 987", 160m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(429), "Riverside Lodge", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(429), "76543-210" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"), "Rua das Flores, 456", 120m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(424), "Cozy Inn", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(424), "54321-987" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("c56db9bc-65d4-40cf-bd0f-427d1b1ba241"), "Trilha da Montanha, 765", 190m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(438), "Mountain View Lodge", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(439), "65432-123" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("dcbb8afa-7a1b-4f3c-bf92-88f9f6863c9d"), "Avenida Central, 876", 130m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(436), "Sorocaba Suites", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(436), "12345-543" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("ee459eae-f928-480b-b795-0fa4ec4dcded"), "Avenida das Estrelas, 123", 250m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(422), "Luxury Palace Hotel", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(422), "12345-678" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("eebfd31c-9492-471f-b844-2dc51d2cc6b7"), "Avenida Beira-Mar, 789", 180m, "Sorocaba", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(425), "Harbor View Hotel", "SP", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(426), "98765-432" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("762f0d15-b883-4577-a543-6191d5893e91"), new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(239), "fer@admin.com.br", "Administrador", new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("016ee195-c138-4ba4-98b6-d8cd6b129715"), null, new Guid("eebfd31c-9492-471f-b844-2dc51d2cc6b7"), 41, 2, 94m, 1, 1, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("1a4f6607-4ce3-4ac8-8585-3576f2027789"), null, new Guid("ee459eae-f928-480b-b795-0fa4ec4dcded"), 96, 3, 135m, 1, 11, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("31deec56-8a89-4836-ab6f-fea56c0b75b3"), null, new Guid("86faabfb-21b8-4eca-a999-db074e489e37"), 28, 4, 141m, 1, 4, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("37fae2e0-c0a3-4d90-babe-ad3daaee523f"), null, new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"), 47, 1, 91m, 1, 8, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("3ccbb7c5-8504-4429-aa6c-e8768a9885d8"), null, new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"), 65, 4, 156m, 1, 8, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("4f1ec501-e2b2-4067-9c06-0fe96e6f23a7"), null, new Guid("86faabfb-21b8-4eca-a999-db074e489e37"), 49, 3, 80m, 1, 5, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("5576f8ba-2dd3-42f5-b8ed-608f5b7850e3"), null, new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"), 1, 3, 143m, 1, 4, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("78d81163-0016-4409-8ffb-956c5bd4a880"), null, new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"), 46, 1, 92m, 1, 11, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("c50d9ecb-c4f9-41a8-af27-5953cce4871b"), null, new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"), 73, 3, 107m, 1, 2, null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("ee85f342-c4c7-45c6-abe4-3aa9e850e866"), null, new Guid("eebfd31c-9492-471f-b844-2dc51d2cc6b7"), 49, 2, 105m, 1, 2, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("0d3b57e8-55ae-405c-b0de-2f30e1288b06"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("03158875-1b25-4844-81f4-8fe88147d56b"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("2045987e-853c-4fec-9c4e-4813347e044b"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("8dc27776-7086-426c-9657-a4f3ebf3c336"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("98a51d43-35d0-495b-9932-c62311f4b130"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("9fe39e98-4bdd-482a-b835-7b6616a9665d"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("c56db9bc-65d4-40cf-bd0f-427d1b1ba241"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("dcbb8afa-7a1b-4f3c-bf92-88f9f6863c9d"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("016ee195-c138-4ba4-98b6-d8cd6b129715"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("1a4f6607-4ce3-4ac8-8585-3576f2027789"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("31deec56-8a89-4836-ab6f-fea56c0b75b3"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("37fae2e0-c0a3-4d90-babe-ad3daaee523f"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("3ccbb7c5-8504-4429-aa6c-e8768a9885d8"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("4f1ec501-e2b2-4067-9c06-0fe96e6f23a7"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("5576f8ba-2dd3-42f5-b8ed-608f5b7850e3"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("78d81163-0016-4409-8ffb-956c5bd4a880"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("c50d9ecb-c4f9-41a8-af27-5953cce4871b"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("ee85f342-c4c7-45c6-abe4-3aa9e850e866"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("762f0d15-b883-4577-a543-6191d5893e91"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("86faabfb-21b8-4eca-a999-db074e489e37"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("ee459eae-f928-480b-b795-0fa4ec4dcded"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("eebfd31c-9492-471f-b844-2dc51d2cc6b7"));

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
    }
}
