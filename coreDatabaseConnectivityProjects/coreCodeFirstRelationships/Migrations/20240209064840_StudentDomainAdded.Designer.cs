﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using coreCodeFirstRelationships.Models;

#nullable disable

namespace coreCodeFirstRelationships.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240209064840_StudentDomainAdded")]
    partial class StudentDomainAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.HasKey("BooksBookId", "CategoriesCategoryId");

                    b.HasIndex("CategoriesCategoryId");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("coreCodeFirstRelationships.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "King",
                            LastName = "Kochhar"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Shreya",
                            LastName = "Sharma"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Sarah",
                            LastName = "Bowling"
                        },
                        new
                        {
                            AuthorId = 4,
                            FirstName = "Gautam",
                            LastName = "Bhalla"
                        });
                });

            modelBuilder.Entity("coreCodeFirstRelationships.Models.AuthorBiography", b =>
                {
                    b.Property<int>("AuthorBiographyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorBiographyId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlaceOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorBiographyId");

                    b.HasIndex("AuthorId")
                        .IsUnique();

                    b.ToTable("authorBiographies");

                    b.HasData(
                        new
                        {
                            AuthorBiographyId = 1,
                            AuthorId = 1,
                            Biography = "Some Details Here",
                            DateOfBirth = new DateTime(2024, 2, 9, 12, 18, 39, 697, DateTimeKind.Local).AddTicks(3989),
                            PlaceOfBirth = "Delhi"
                        },
                        new
                        {
                            AuthorBiographyId = 2,
                            AuthorId = 2,
                            Biography = "Some Details Here",
                            DateOfBirth = new DateTime(2024, 2, 9, 12, 18, 39, 697, DateTimeKind.Local).AddTicks(4005),
                            PlaceOfBirth = "Mumbai"
                        },
                        new
                        {
                            AuthorBiographyId = 3,
                            AuthorId = 3,
                            Biography = "Some Details Here",
                            DateOfBirth = new DateTime(2024, 2, 9, 12, 18, 39, 697, DateTimeKind.Local).AddTicks(4007),
                            PlaceOfBirth = "Chennai"
                        },
                        new
                        {
                            AuthorBiographyId = 4,
                            AuthorId = 4,
                            Biography = "Some Details Here",
                            DateOfBirth = new DateTime(2024, 2, 9, 12, 18, 39, 697, DateTimeKind.Local).AddTicks(4009),
                            PlaceOfBirth = "Hyderabad"
                        });
                });

            modelBuilder.Entity("coreCodeFirstRelationships.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("coreCodeFirstRelationships.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("coreCodeFirstRelationships.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.HasOne("coreCodeFirstRelationships.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("coreCodeFirstRelationships.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("coreCodeFirstRelationships.Models.AuthorBiography", b =>
                {
                    b.HasOne("coreCodeFirstRelationships.Models.Author", "Author")
                        .WithOne("Biography")
                        .HasForeignKey("coreCodeFirstRelationships.Models.AuthorBiography", "AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("coreCodeFirstRelationships.Models.Book", b =>
                {
                    b.HasOne("coreCodeFirstRelationships.Models.Author", "author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.Navigation("author");
                });

            modelBuilder.Entity("coreCodeFirstRelationships.Models.Author", b =>
                {
                    b.Navigation("Biography");

                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
