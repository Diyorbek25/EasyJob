﻿// <auto-generated />
using System;
using EasyJob.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyJob.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230117055100_RefreshToken")]
    partial class RefreshToken
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EasyJob.Domain.Entities.Users.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<short?>("PostalCode")
                        .HasColumnType("smallint");

                    b.Property<string>("Region")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Addresses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc56836e-0345-4f01-a883-47f39e32e079"),
                            Country = "Uzbekistan"
                        });
                });

            modelBuilder.Entity("EasyJob.Domain.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc56836e-0345-4f01-a883-47f39e32e079"),
                            AddressId = new Guid("bc56836e-0345-4f01-a883-47f39e32e079"),
                            CreatedAt = new DateTime(2023, 1, 17, 5, 50, 59, 983, DateTimeKind.Utc).AddTicks(771),
                            Email = "toxirjon@gmail.com",
                            FirstName = "Toxirjon",
                            PasswordHash = "12345",
                            PhoneNumber = "931234567",
                            Role = 4,
                            Salt = "affc2435-b726-4ea2-9dda-9a4104e913c7"
                        });
                });

            modelBuilder.Entity("EasyJob.Domain.Entities.Users.User", b =>
                {
                    b.HasOne("EasyJob.Domain.Entities.Users.Address", "Address")
                        .WithOne()
                        .HasForeignKey("EasyJob.Domain.Entities.Users.User", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
