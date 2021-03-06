﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Data;

namespace Test.Data.Migrations
{
    [DbContext(typeof(TestContext))]
    partial class TestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test.Core.Entities.SubTestModel", b =>
                {
                    b.Property<int>("SubTestModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<long>("Phone")
                        .HasColumnType("bigint")
                        .HasMaxLength(10);

                    b.Property<int>("TestModelId")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("SubTestModelId");

                    b.HasIndex("TestModelId")
                        .IsUnique();

                    b.ToTable("SubTest");

                    b.HasData(
                        new
                        {
                            SubTestModelId = 1,
                            City = "Ankara",
                            Country = "Turkey",
                            Phone = 5321234567L,
                            TestModelId = 1,
                            isDeleted = false
                        },
                        new
                        {
                            SubTestModelId = 2,
                            City = "Istanbul",
                            Country = "Turkey",
                            Phone = 5321234567L,
                            TestModelId = 2,
                            isDeleted = false
                        },
                        new
                        {
                            SubTestModelId = 3,
                            City = "Izmir",
                            Country = "Turkey",
                            Phone = 5321234567L,
                            TestModelId = 3,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Test.Core.Entities.TestModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdentityNo")
                        .HasColumnType("bigint")
                        .HasMaxLength(11);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Test");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1995, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdentityNo = 12345678910L,
                            Name = "Name1",
                            SurName = "Surname1",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1995, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdentityNo = 12345678912L,
                            Name = "Name2",
                            SurName = "Surname2",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1995, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdentityNo = 12345678914L,
                            Name = "Name3",
                            SurName = "Surname3",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Test.Core.Entities.SubTestModel", b =>
                {
                    b.HasOne("Test.Core.Entities.TestModel", "TestModel")
                        .WithOne("SubTestModels")
                        .HasForeignKey("Test.Core.Entities.SubTestModel", "TestModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
