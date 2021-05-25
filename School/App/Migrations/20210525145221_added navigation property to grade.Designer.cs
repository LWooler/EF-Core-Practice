﻿// <auto-generated />
using App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20210525145221_added navigation property to grade")]
    partial class addednavigationpropertytograde
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("App.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Value")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Track 302",
                            StudentId = 1,
                            Value = 99.5f
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Track 302",
                            StudentId = 2,
                            Value = 45f
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Track 302",
                            StudentId = 3,
                            Value = 87.25f
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Martial Arts 302",
                            StudentId = 1,
                            Value = 100f
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "Martial Arts 302",
                            StudentId = 2,
                            Value = 98.99f
                        },
                        new
                        {
                            Id = 6,
                            CourseName = "Calculus 302",
                            StudentId = 4,
                            Value = 76.5f
                        },
                        new
                        {
                            Id = 7,
                            CourseName = "Calculus 302",
                            StudentId = 5,
                            Value = 88f
                        });
                });

            modelBuilder.Entity("App.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Classification")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            Classification = 0,
                            FirstName = "Barry",
                            LastName = "Allen"
                        },
                        new
                        {
                            Id = 2,
                            Age = 42,
                            Classification = 1,
                            FirstName = "Frank",
                            LastName = "Castle"
                        },
                        new
                        {
                            Id = 3,
                            Age = 29,
                            Classification = 2,
                            FirstName = "Clark",
                            LastName = "Kent"
                        },
                        new
                        {
                            Id = 4,
                            Age = 39,
                            Classification = 3,
                            FirstName = "Bruce",
                            LastName = "Wayne"
                        },
                        new
                        {
                            Id = 5,
                            Age = 19,
                            Classification = 0,
                            FirstName = "Gwen",
                            LastName = "Stacy"
                        },
                        new
                        {
                            Id = 6,
                            Age = 19,
                            Classification = 0,
                            FirstName = "Peter",
                            LastName = "Parker"
                        });
                });

            modelBuilder.Entity("App.Models.Grade", b =>
                {
                    b.HasOne("App.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("App.Models.Student", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}