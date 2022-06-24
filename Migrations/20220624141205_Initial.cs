using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Teachy.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Auth0Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "Date", nullable: true),
                    CountryOfOriginId = table.Column<int>(type: "integer", nullable: true)
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
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    InviteCode = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_UserProfiles_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SubCategoryId = table.Column<int>(type: "integer", nullable: false),
                    ResourceTypeId = table.Column<int>(type: "integer", nullable: false),
                    Uri = table.Column<string>(type: "text", nullable: true),
                    FileContent = table.Column<byte[]>(type: "bytea", nullable: true),
                    AuthorId = table.Column<int>(type: "integer", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Resources_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassId = table.Column<int>(type: "integer", nullable: false),
                    MemberId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassMembers_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassMembers_UserProfiles_MemberId",
                        column: x => x.MemberId,
                        principalTable: "UserProfiles",
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
                    { 17, "Brazil" },
                    { 18, "Brunei" },
                    { 19, "Bulgaria" },
                    { 20, "Cambodia" },
                    { 21, "Cameroon" },
                    { 22, "Canada" },
                    { 23, "Chile" },
                    { 24, "China" },
                    { 25, "Colombia" },
                    { 26, "Congo - Kinshasa" },
                    { 27, "Costa Rica" },
                    { 28, "Côte d’Ivoire" },
                    { 29, "Croatia" },
                    { 30, "Cuba" },
                    { 31, "Czechia" },
                    { 32, "Denmark" },
                    { 33, "Dominican Republic" },
                    { 34, "Ecuador" },
                    { 35, "Egypt" },
                    { 36, "El Salvador" },
                    { 37, "Eritrea" },
                    { 38, "Estonia" },
                    { 39, "Ethiopia" },
                    { 40, "Faroe Islands" },
                    { 41, "Finland" },
                    { 42, "France" },
                    { 43, "Georgia" },
                    { 44, "Germany" },
                    { 45, "Greece" },
                    { 46, "Greenland" },
                    { 47, "Guatemala" },
                    { 48, "Haiti" },
                    { 49, "Honduras" },
                    { 50, "Hong Kong SAR China" },
                    { 51, "Hungary" },
                    { 52, "Iceland" },
                    { 53, "India" },
                    { 54, "Indonesia" },
                    { 55, "Iran" },
                    { 56, "Iraq" },
                    { 57, "Ireland" },
                    { 58, "Israel" },
                    { 59, "Italy" },
                    { 60, "Jamaica" },
                    { 61, "Japan" },
                    { 62, "Jordan" },
                    { 63, "Kazakhstan" },
                    { 64, "Kenya" },
                    { 65, "Kuwait" },
                    { 66, "Kyrgyzstan" },
                    { 67, "Laos" },
                    { 68, "Latin America" },
                    { 69, "Latvia" },
                    { 70, "Lebanon" },
                    { 71, "Libya" },
                    { 72, "Liechtenstein" },
                    { 73, "Lithuania" },
                    { 74, "Luxembourg" },
                    { 75, "Malaysia" },
                    { 76, "Mali" },
                    { 77, "Malta" },
                    { 78, "Mexico" },
                    { 79, "Moldova" },
                    { 80, "Monaco" },
                    { 81, "Mongolia" },
                    { 82, "Montenegro" },
                    { 83, "Morocco" },
                    { 84, "Myanmar (Burma)" },
                    { 85, "Nepal" },
                    { 86, "Netherlands" },
                    { 87, "New Zealand" },
                    { 88, "Nicaragua" },
                    { 89, "Nigeria" },
                    { 90, "North Macedonia" },
                    { 91, "Norway" },
                    { 92, "Oman" },
                    { 93, "Pakistan" },
                    { 94, "Panama" },
                    { 95, "Paraguay" },
                    { 96, "Peru" },
                    { 97, "Philippines" },
                    { 98, "Poland" },
                    { 99, "Portugal" },
                    { 100, "Puerto Rico" },
                    { 101, "Qatar" },
                    { 102, "Réunion" },
                    { 103, "Romania" },
                    { 104, "Russia" },
                    { 105, "Rwanda" },
                    { 106, "Saudi Arabia" },
                    { 107, "Senegal" },
                    { 108, "Serbia" },
                    { 109, "Singapore" },
                    { 110, "Slovakia" },
                    { 111, "Slovenia" },
                    { 112, "Somalia" },
                    { 113, "South Africa" },
                    { 114, "South Korea" },
                    { 115, "Spain" },
                    { 116, "Sri Lanka" },
                    { 117, "Sweden" },
                    { 118, "Switzerland" },
                    { 119, "Syria" },
                    { 120, "Thailand" },
                    { 121, "Trinidad & Tobago" },
                    { 122, "Tunisia" },
                    { 123, "Turkey" },
                    { 124, "Turkmenistan" },
                    { 125, "Ukraine" },
                    { 126, "United Arab Emirates" },
                    { 127, "United Kingdom" },
                    { 128, "United States" },
                    { 129, "Uruguay" },
                    { 130, "Uzbekistan" },
                    { 131, "Venezuela" },
                    { 132, "Vietnam" },
                    { 133, "World" },
                    { 134, "Yemen" },
                    { 135, "Zimbabwe" }
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
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_OwnerId",
                table: "Classes",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassMembers_ClassId",
                table: "ClassMembers",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassMembers_MemberId",
                table: "ClassMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_AuthorId",
                table: "Resources",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ResourceTypeId",
                table: "Resources",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_SubCategoryId",
                table: "Resources",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Name_CategoryId",
                table: "SubCategories",
                columns: new[] { "Name", "CategoryId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassMembers");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "ResourceType");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
