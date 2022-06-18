using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teachy.Migrations
{
    public partial class InitialResourceModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CountryOfOriginId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Countries_CountryOfOriginId",
                        column: x => x.CountryOfOriginId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceTypeId = table.Column<int>(type: "int", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resources_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resources_ResourceType_ResourceTypeId",
                        column: x => x.ResourceTypeId,
                        principalTable: "ResourceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Afghanistan" },
                    { 2, "Albania" },
                    { 3, "Algeria" },
                    { 4, "Argentina" },
                    { 5, "Armenia" },
                    { 6, "Australia" },
                    { 7, "Austria" },
                    { 8, "Azerbaijan" },
                    { 9, "Bahrain" },
                    { 10, "Bangladesh" },
                    { 11, "Belarus" },
                    { 12, "Belgium" },
                    { 13, "Belize" },
                    { 14, "Bhutan" },
                    { 15, "Bolivia" },
                    { 16, "Bosnia & Herzegovina" },
                    { 17, "Botswana" },
                    { 18, "Brazil" },
                    { 19, "Brunei" },
                    { 20, "Bulgaria" },
                    { 21, "Cambodia" },
                    { 22, "Cameroon" },
                    { 23, "Canada" },
                    { 24, "Caribbean" },
                    { 25, "Chile" },
                    { 26, "China" },
                    { 27, "Colombia" },
                    { 28, "Congo (DRC)" },
                    { 29, "Costa Rica" },
                    { 30, "Côte d’Ivoire" },
                    { 31, "Croatia" },
                    { 32, "Cuba" },
                    { 33, "Czechia" },
                    { 34, "Denmark" },
                    { 35, "Dominican Republic" },
                    { 36, "Ecuador" },
                    { 37, "Egypt" },
                    { 38, "El Salvador" },
                    { 39, "Eritrea" },
                    { 40, "Estonia" },
                    { 41, "Ethiopia" },
                    { 42, "Faroe Islands" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 43, "Finland" },
                    { 44, "France" },
                    { 45, "Georgia" },
                    { 46, "Germany" },
                    { 47, "Greece" },
                    { 48, "Greenland" },
                    { 49, "Guatemala" },
                    { 50, "Haiti" },
                    { 51, "Honduras" },
                    { 52, "Hong Kong SAR" },
                    { 53, "Hungary" },
                    { 54, "Iceland" },
                    { 55, "India" },
                    { 56, "Indonesia" },
                    { 57, "Iran" },
                    { 58, "Iraq" },
                    { 59, "Ireland" },
                    { 60, "Israel" },
                    { 61, "Italy" },
                    { 62, "Jamaica" },
                    { 63, "Japan" },
                    { 64, "Jordan" },
                    { 65, "Kazakhstan" },
                    { 66, "Kenya" },
                    { 67, "Korea" },
                    { 68, "Kuwait" },
                    { 69, "Kyrgyzstan" },
                    { 70, "Laos" },
                    { 71, "Latin America" },
                    { 72, "Latvia" },
                    { 73, "Lebanon" },
                    { 74, "Libya" },
                    { 75, "Liechtenstein" },
                    { 76, "Lithuania" },
                    { 77, "Luxembourg" },
                    { 78, "Malaysia" },
                    { 79, "Maldives" },
                    { 80, "Mali" },
                    { 81, "Malta" },
                    { 82, "Mexico" },
                    { 83, "Moldova" },
                    { 84, "Monaco" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 85, "Mongolia" },
                    { 86, "Montenegro" },
                    { 87, "Morocco" },
                    { 88, "Myanmar" },
                    { 89, "Nepal" },
                    { 90, "Netherlands" },
                    { 91, "New Zealand" },
                    { 92, "Nicaragua" },
                    { 93, "Nigeria" },
                    { 94, "North Macedonia" },
                    { 95, "Norway" },
                    { 96, "Oman" },
                    { 97, "Pakistan" },
                    { 98, "Panama" },
                    { 99, "Paraguay" },
                    { 100, "Peru" },
                    { 101, "Philippines" },
                    { 102, "Poland" },
                    { 103, "Portugal" },
                    { 104, "Puerto Rico" },
                    { 105, "Qatar" },
                    { 106, "Réunion" },
                    { 107, "Romania" },
                    { 108, "Russia" },
                    { 109, "Rwanda" },
                    { 110, "Saudi Arabia" },
                    { 111, "Senegal" },
                    { 112, "Serbia" },
                    { 113, "Singapore" },
                    { 114, "Slovakia" },
                    { 115, "Slovenia" },
                    { 116, "Somalia" },
                    { 117, "South Africa" },
                    { 118, "Spain" },
                    { 119, "Sri Lanka" },
                    { 120, "Sweden" },
                    { 121, "Switzerland" },
                    { 122, "Syria" },
                    { 123, "Thailand" },
                    { 124, "Trinidad & Tobago" },
                    { 125, "Tunisia" },
                    { 126, "Turkey" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 127, "Turkmenistan" },
                    { 128, "Ukraine" },
                    { 129, "United Arab Emirates" },
                    { 130, "United Kingdom" },
                    { 131, "United States" },
                    { 132, "Uruguay" },
                    { 133, "Uzbekistan" },
                    { 134, "Venezuela" },
                    { 135, "Vietnam" },
                    { 136, "World" },
                    { 137, "Yemen" },
                    { 138, "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "ResourceType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Uri" },
                    { 2, "Document" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_CountryOfOriginId",
                table: "Authors",
                column: "CountryOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_AuthorId",
                table: "Resources",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ResourceTypeId",
                table: "Resources",
                column: "ResourceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "ResourceType");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
