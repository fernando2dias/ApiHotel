using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class fixreview5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("e6246583-2c53-4310-a72b-16f807674d18"), new DateTime(1986, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "111.222.333-44", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8837), "fernando3dias@gmail.com", "Dias Motta", "Fernando", null, "123mudar", null, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("2a929d45-1a92-41d6-9f94-cbee7fa3aed6"), "Avenida Central, 876", 130m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8896), "Sorocaba Suites", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8897), "12345-543" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("2ec772b5-10ce-44e6-a39c-d10a6a4ea2d5"), "Trilha da Montanha, 765", 190m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8901), "Mountain View Lodge", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8901), "65432-123" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("2fab9ede-2d00-4d96-a639-11bd168d6a38"), "Praia da Areia Dourada, S/N", 300m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8887), "Golden Sands Resort", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8887), "34567-890" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"), "Avenida Beira-Mar, 789", 180m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8885), "Harbor View Hotel", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8886), "98765-432" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("54b54b3e-01ab-4f9a-9f97-78e90caa1843"), "Rua das Montanhas, 567", 200m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8895), "Majestic Heights Hotel", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8895), "54321-234" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("5d82ff9c-349d-471a-beda-b5abfb7f06bf"), "Rua das Flores, 456", 120m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8883), "Cozy Inn", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8884), "54321-987" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("73413cb7-1e85-4cc5-93db-517aa5fd8b0d"), "Avenida do Pôr do Sol, 321", 140m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8893), "Sunset View Inn", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8893), "87654-321" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("746aff68-3e9f-4621-990d-8889275aba05"), "Rodovia Senador José Ermírio de Moraes, 1425", 150m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8879), "Facens Hotel", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8880), "18085-784" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("9670ad43-f26d-4989-a634-78bf33ae9cf1"), "Margem do Rio, 987", 160m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8889), "Riverside Lodge", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8890), "76543-210" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("971dc5b3-b1ce-4ff1-b3a1-3a02155a7c82"), "Praça Principal, 654", 280m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8891), "The Grand Plaza Hotel", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8892), "23456-789" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "AvgTicket", "City", "CreateAt", "Name", "State", "UpdateAt", "ZipCode" },
                values: new object[] { new Guid("ae6eae3f-870a-4de0-a14a-9ad5baaf1929"), "Avenida das Estrelas, 123", 250m, "Sorocaba", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8882), "Luxury Palace Hotel", "SP", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8882), "12345-678" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("053d83d1-559c-4550-9668-851ea3eb26ac"), "Nada excepcional, mas foi ok", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8986), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 3, new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("0bd286be-152a-4834-8696-f59d68c62fa2"), "Terrível! Evite este lugar a todo custo", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8983), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 0, new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("33ab9237-7e1d-4e5c-a714-00e8e32899b6"), "Experiência positiva no hotel", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8972), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 4, new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("36d0d81c-4cbd-482c-bfd5-3261c1226d6a"), "Fiquei satisfeito com a estadia", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8981), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 4, new Guid("746aff68-3e9f-4621-990d-8889275aba05"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("6b6abfb3-292c-4711-8668-4cdff982e0ca"), "Melhor hotel que já visitei", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8985), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 5, new Guid("ae6eae3f-870a-4de0-a14a-9ad5baaf1929"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("7dca8101-055d-44b9-a861-43878356dc49"), "Bom serviço, mas pode melhorar", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8970), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 3, new Guid("ae6eae3f-870a-4de0-a14a-9ad5baaf1929"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("8a8fe94a-207f-495d-884c-4058aeb0d887"), "Não fiquei satisfeito com a estadia", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8974), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 2, new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("ab6da024-33c8-4a64-99a7-142a953ef5a1"), "Boa escolha para a estadia", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8988), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 4, new Guid("ae6eae3f-870a-4de0-a14a-9ad5baaf1929"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("c0cf12f2-6ce2-4f2a-a7b1-fe94812088d8"), "Incrível! Superou minhas expectativas", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8978), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 5, new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreateAt", "CustomerId", "EvaluationStars", "HotelId", "UpdateAt" },
                values: new object[] { new Guid("d14d43da-4592-49ca-a944-575b2cb803f9"), "Péssima experiência. Não recomendo", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8979), new Guid("e6246583-2c53-4310-a72b-16f807674d18"), 1, new Guid("ae6eae3f-870a-4de0-a14a-9ad5baaf1929"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("c74e2996-2485-4eb2-9d6c-03d7d8a0b397"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8680), "fer@admin.com.br", "Administrador", new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("0ee99932-398b-48a4-9aa0-36125ae0e3db"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8956), new Guid("5d82ff9c-349d-471a-beda-b5abfb7f06bf"), 74, 2, 95m, 1, 7, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("112b2a60-2444-48ef-9f9d-a6c7f8586007"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8954), new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"), 59, 1, 166m, 1, 5, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("13dde1cc-853e-4ec6-9d31-3643a53ff5c6"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8943), new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"), 3, 2, 155m, 1, 11, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("260f640b-03d3-488c-9ad2-e2ed5c169ceb"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8940), new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"), 45, 2, 80m, 1, 6, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("2eb4d441-6927-438d-bccd-cf5a08ed34cb"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8938), new Guid("ae6eae3f-870a-4de0-a14a-9ad5baaf1929"), 29, 4, 106m, 1, 9, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("4399ecc2-b751-42f1-8558-18be5cb6096b"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8947), new Guid("5d82ff9c-349d-471a-beda-b5abfb7f06bf"), 63, 3, 182m, 1, 1, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("70449765-5fb3-41a8-8a01-c2b89fc1eefa"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8951), new Guid("5d82ff9c-349d-471a-beda-b5abfb7f06bf"), 84, 3, 135m, 1, 11, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("be4fa41f-03b6-41e5-84d9-013b640de52b"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8935), new Guid("5d82ff9c-349d-471a-beda-b5abfb7f06bf"), 9, 4, 132m, 1, 10, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("ddced037-d7c3-400c-88d7-2e774b41aac3"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8932), new Guid("ae6eae3f-870a-4de0-a14a-9ad5baaf1929"), 98, 3, 180m, 1, 5, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "CreateAt", "HotelId", "Number", "NumberBeds", "PricePerNight", "Status", "TypeRoom", "UpdateAt" },
                values: new object[] { new Guid("e69eee1c-4920-4fc1-a75a-3e0288add687"), new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8949), new Guid("5d82ff9c-349d-471a-beda-b5abfb7f06bf"), 29, 2, 93m, 1, 7, new DateTime(2023, 11, 8, 21, 49, 17, 767, DateTimeKind.Local).AddTicks(8949) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e6246583-2c53-4310-a72b-16f807674d18"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("2a929d45-1a92-41d6-9f94-cbee7fa3aed6"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("2ec772b5-10ce-44e6-a39c-d10a6a4ea2d5"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("2fab9ede-2d00-4d96-a639-11bd168d6a38"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("54b54b3e-01ab-4f9a-9f97-78e90caa1843"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("73413cb7-1e85-4cc5-93db-517aa5fd8b0d"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("746aff68-3e9f-4621-990d-8889275aba05"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("9670ad43-f26d-4989-a634-78bf33ae9cf1"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("971dc5b3-b1ce-4ff1-b3a1-3a02155a7c82"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("053d83d1-559c-4550-9668-851ea3eb26ac"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("0bd286be-152a-4834-8696-f59d68c62fa2"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("33ab9237-7e1d-4e5c-a714-00e8e32899b6"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("36d0d81c-4cbd-482c-bfd5-3261c1226d6a"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("6b6abfb3-292c-4711-8668-4cdff982e0ca"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("7dca8101-055d-44b9-a861-43878356dc49"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("8a8fe94a-207f-495d-884c-4058aeb0d887"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("ab6da024-33c8-4a64-99a7-142a953ef5a1"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("c0cf12f2-6ce2-4f2a-a7b1-fe94812088d8"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("d14d43da-4592-49ca-a944-575b2cb803f9"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("0ee99932-398b-48a4-9aa0-36125ae0e3db"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("112b2a60-2444-48ef-9f9d-a6c7f8586007"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("13dde1cc-853e-4ec6-9d31-3643a53ff5c6"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("260f640b-03d3-488c-9ad2-e2ed5c169ceb"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("2eb4d441-6927-438d-bccd-cf5a08ed34cb"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("4399ecc2-b751-42f1-8558-18be5cb6096b"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("70449765-5fb3-41a8-8a01-c2b89fc1eefa"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("be4fa41f-03b6-41e5-84d9-013b640de52b"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("ddced037-d7c3-400c-88d7-2e774b41aac3"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("e69eee1c-4920-4fc1-a75a-3e0288add687"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c74e2996-2485-4eb2-9d6c-03d7d8a0b397"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("3cbbf850-706a-4c4d-874b-c6f9e8c85bf3"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("5d82ff9c-349d-471a-beda-b5abfb7f06bf"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("ae6eae3f-870a-4de0-a14a-9ad5baaf1929"));

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
    }
}
