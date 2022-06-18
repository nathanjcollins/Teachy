﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teachy.Data;

#nullable disable

namespace Teachy.Migrations
{
    [DbContext(typeof(TeachyDbContext))]
    partial class TeachyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Teachy.Data.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryOfOriginId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryOfOriginId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Teachy.Data.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("InviteCode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Teachy.Data.Models.ClassMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("MemberId");

                    b.ToTable("ClassMembers");
                });

            modelBuilder.Entity("Teachy.Data.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Afghanistan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Albania"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Algeria"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Argentina"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Armenia"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Australia"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Austria"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Azerbaijan"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Bahrain"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Bangladesh"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Belarus"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Belgium"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Belize"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Bhutan"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Bolivia"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Bosnia & Herzegovina"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Botswana"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Brazil"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Brunei"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Bulgaria"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Cambodia"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Cameroon"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Canada"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Caribbean"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Chile"
                        },
                        new
                        {
                            Id = 26,
                            Name = "China"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Colombia"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Congo (DRC)"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Costa Rica"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Côte d’Ivoire"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Croatia"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Cuba"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Czechia"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Denmark"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Dominican Republic"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Ecuador"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Egypt"
                        },
                        new
                        {
                            Id = 38,
                            Name = "El Salvador"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Eritrea"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Estonia"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Ethiopia"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Faroe Islands"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Finland"
                        },
                        new
                        {
                            Id = 44,
                            Name = "France"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Georgia"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Greece"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Greenland"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Guatemala"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Haiti"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Honduras"
                        },
                        new
                        {
                            Id = 52,
                            Name = "Hong Kong SAR"
                        },
                        new
                        {
                            Id = 53,
                            Name = "Hungary"
                        },
                        new
                        {
                            Id = 54,
                            Name = "Iceland"
                        },
                        new
                        {
                            Id = 55,
                            Name = "India"
                        },
                        new
                        {
                            Id = 56,
                            Name = "Indonesia"
                        },
                        new
                        {
                            Id = 57,
                            Name = "Iran"
                        },
                        new
                        {
                            Id = 58,
                            Name = "Iraq"
                        },
                        new
                        {
                            Id = 59,
                            Name = "Ireland"
                        },
                        new
                        {
                            Id = 60,
                            Name = "Israel"
                        },
                        new
                        {
                            Id = 61,
                            Name = "Italy"
                        },
                        new
                        {
                            Id = 62,
                            Name = "Jamaica"
                        },
                        new
                        {
                            Id = 63,
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 64,
                            Name = "Jordan"
                        },
                        new
                        {
                            Id = 65,
                            Name = "Kazakhstan"
                        },
                        new
                        {
                            Id = 66,
                            Name = "Kenya"
                        },
                        new
                        {
                            Id = 67,
                            Name = "Korea"
                        },
                        new
                        {
                            Id = 68,
                            Name = "Kuwait"
                        },
                        new
                        {
                            Id = 69,
                            Name = "Kyrgyzstan"
                        },
                        new
                        {
                            Id = 70,
                            Name = "Laos"
                        },
                        new
                        {
                            Id = 71,
                            Name = "Latin America"
                        },
                        new
                        {
                            Id = 72,
                            Name = "Latvia"
                        },
                        new
                        {
                            Id = 73,
                            Name = "Lebanon"
                        },
                        new
                        {
                            Id = 74,
                            Name = "Libya"
                        },
                        new
                        {
                            Id = 75,
                            Name = "Liechtenstein"
                        },
                        new
                        {
                            Id = 76,
                            Name = "Lithuania"
                        },
                        new
                        {
                            Id = 77,
                            Name = "Luxembourg"
                        },
                        new
                        {
                            Id = 78,
                            Name = "Malaysia"
                        },
                        new
                        {
                            Id = 79,
                            Name = "Maldives"
                        },
                        new
                        {
                            Id = 80,
                            Name = "Mali"
                        },
                        new
                        {
                            Id = 81,
                            Name = "Malta"
                        },
                        new
                        {
                            Id = 82,
                            Name = "Mexico"
                        },
                        new
                        {
                            Id = 83,
                            Name = "Moldova"
                        },
                        new
                        {
                            Id = 84,
                            Name = "Monaco"
                        },
                        new
                        {
                            Id = 85,
                            Name = "Mongolia"
                        },
                        new
                        {
                            Id = 86,
                            Name = "Montenegro"
                        },
                        new
                        {
                            Id = 87,
                            Name = "Morocco"
                        },
                        new
                        {
                            Id = 88,
                            Name = "Myanmar"
                        },
                        new
                        {
                            Id = 89,
                            Name = "Nepal"
                        },
                        new
                        {
                            Id = 90,
                            Name = "Netherlands"
                        },
                        new
                        {
                            Id = 91,
                            Name = "New Zealand"
                        },
                        new
                        {
                            Id = 92,
                            Name = "Nicaragua"
                        },
                        new
                        {
                            Id = 93,
                            Name = "Nigeria"
                        },
                        new
                        {
                            Id = 94,
                            Name = "North Macedonia"
                        },
                        new
                        {
                            Id = 95,
                            Name = "Norway"
                        },
                        new
                        {
                            Id = 96,
                            Name = "Oman"
                        },
                        new
                        {
                            Id = 97,
                            Name = "Pakistan"
                        },
                        new
                        {
                            Id = 98,
                            Name = "Panama"
                        },
                        new
                        {
                            Id = 99,
                            Name = "Paraguay"
                        },
                        new
                        {
                            Id = 100,
                            Name = "Peru"
                        },
                        new
                        {
                            Id = 101,
                            Name = "Philippines"
                        },
                        new
                        {
                            Id = 102,
                            Name = "Poland"
                        },
                        new
                        {
                            Id = 103,
                            Name = "Portugal"
                        },
                        new
                        {
                            Id = 104,
                            Name = "Puerto Rico"
                        },
                        new
                        {
                            Id = 105,
                            Name = "Qatar"
                        },
                        new
                        {
                            Id = 106,
                            Name = "Réunion"
                        },
                        new
                        {
                            Id = 107,
                            Name = "Romania"
                        },
                        new
                        {
                            Id = 108,
                            Name = "Russia"
                        },
                        new
                        {
                            Id = 109,
                            Name = "Rwanda"
                        },
                        new
                        {
                            Id = 110,
                            Name = "Saudi Arabia"
                        },
                        new
                        {
                            Id = 111,
                            Name = "Senegal"
                        },
                        new
                        {
                            Id = 112,
                            Name = "Serbia"
                        },
                        new
                        {
                            Id = 113,
                            Name = "Singapore"
                        },
                        new
                        {
                            Id = 114,
                            Name = "Slovakia"
                        },
                        new
                        {
                            Id = 115,
                            Name = "Slovenia"
                        },
                        new
                        {
                            Id = 116,
                            Name = "Somalia"
                        },
                        new
                        {
                            Id = 117,
                            Name = "South Africa"
                        },
                        new
                        {
                            Id = 118,
                            Name = "Spain"
                        },
                        new
                        {
                            Id = 119,
                            Name = "Sri Lanka"
                        },
                        new
                        {
                            Id = 120,
                            Name = "Sweden"
                        },
                        new
                        {
                            Id = 121,
                            Name = "Switzerland"
                        },
                        new
                        {
                            Id = 122,
                            Name = "Syria"
                        },
                        new
                        {
                            Id = 123,
                            Name = "Thailand"
                        },
                        new
                        {
                            Id = 124,
                            Name = "Trinidad & Tobago"
                        },
                        new
                        {
                            Id = 125,
                            Name = "Tunisia"
                        },
                        new
                        {
                            Id = 126,
                            Name = "Turkey"
                        },
                        new
                        {
                            Id = 127,
                            Name = "Turkmenistan"
                        },
                        new
                        {
                            Id = 128,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 129,
                            Name = "United Arab Emirates"
                        },
                        new
                        {
                            Id = 130,
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Id = 131,
                            Name = "United States"
                        },
                        new
                        {
                            Id = 132,
                            Name = "Uruguay"
                        },
                        new
                        {
                            Id = 133,
                            Name = "Uzbekistan"
                        },
                        new
                        {
                            Id = 134,
                            Name = "Venezuela"
                        },
                        new
                        {
                            Id = 135,
                            Name = "Vietnam"
                        },
                        new
                        {
                            Id = 136,
                            Name = "World"
                        },
                        new
                        {
                            Id = 137,
                            Name = "Yemen"
                        },
                        new
                        {
                            Id = 138,
                            Name = "Zimbabwe"
                        });
                });

            modelBuilder.Entity("Teachy.Data.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<byte[]>("FileContent")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResourceTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Uri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ResourceTypeId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("Teachy.Data.Models.ResourceType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ResourceType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Uri"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Document"
                        });
                });

            modelBuilder.Entity("Teachy.Data.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Auth0Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Teachy.Data.Models.Author", b =>
                {
                    b.HasOne("Teachy.Data.Models.Country", "CountryOfOrigin")
                        .WithMany()
                        .HasForeignKey("CountryOfOriginId");

                    b.Navigation("CountryOfOrigin");
                });

            modelBuilder.Entity("Teachy.Data.Models.Class", b =>
                {
                    b.HasOne("Teachy.Data.Models.UserProfile", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Teachy.Data.Models.ClassMember", b =>
                {
                    b.HasOne("Teachy.Data.Models.Class", "Class")
                        .WithMany("ClassMembers")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teachy.Data.Models.UserProfile", "Member")
                        .WithMany("ClassMembers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Teachy.Data.Models.Resource", b =>
                {
                    b.HasOne("Teachy.Data.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teachy.Data.Models.ResourceType", "ResourceType")
                        .WithMany()
                        .HasForeignKey("ResourceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("ResourceType");
                });

            modelBuilder.Entity("Teachy.Data.Models.Class", b =>
                {
                    b.Navigation("ClassMembers");
                });

            modelBuilder.Entity("Teachy.Data.Models.UserProfile", b =>
                {
                    b.Navigation("ClassMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
