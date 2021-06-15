﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserManagement.API;

namespace UserManagement.API.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20210615030033_Change in DB")]
    partial class ChangeinDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("UserManagement.API.Models.UserMaster", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PCode")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserMasters");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "admin@test.com",
                            FirstName = "Admin",
                            IsActive = true,
                            LastName = "Main",
                            PCode = "HCL000"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "Micky@test.com",
                            FirstName = "Micky",
                            IsActive = true,
                            LastName = "Mouse",
                            PCode = "HCL001"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "Ben@test.com",
                            FirstName = "Ben",
                            IsActive = false,
                            LastName = "Ten",
                            PCode = "HCL002"
                        },
                        new
                        {
                            UserId = 4,
                            Email = "Choota@test.com",
                            FirstName = "Choota",
                            IsActive = true,
                            LastName = "Bheen",
                            PCode = "HCL031"
                        },
                        new
                        {
                            UserId = 5,
                            Email = "Paw@test.com",
                            FirstName = "Paw",
                            IsActive = false,
                            LastName = "Patrol",
                            PCode = "HCL042"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
