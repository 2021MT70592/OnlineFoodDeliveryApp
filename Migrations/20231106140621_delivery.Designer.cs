﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineFoodDeliverySystem.Models.DbContext;

#nullable disable

namespace OnlineFoodDeliverySystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231106140621_delivery")]
    partial class delivery
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d1bc70df-540c-4dca-82fd-01cbac073c14",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "36c16cdf-e3ea-4df0-b15e-5cb60fd5e04f",
                            ConcurrencyStamp = "1",
                            Name = "User",
                            NormalizedName = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.CustomUserTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CustomUserDetails");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.DeliveryDetails", b =>
                {
                    b.Property<int>("Delivery_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Delivery_Id"));

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Delivery_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("Delivery_Id");

                    b.HasIndex("OrderID");

                    b.ToTable("DeliveryDetails");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.MenuItemsList", b =>
                {
                    b.Property<int>("Item_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Item_ID"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Restaurant_Id")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Item_ID");

                    b.HasIndex("Restaurant_Id");

                    b.ToTable("MenuDetails");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.OrderDetails", b =>
                {
                    b.Property<int>("order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("order_id"));

                    b.Property<string>("Delivery_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Order_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("order_id");

                    b.HasIndex("user_id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.Payment", b =>
                {
                    b.Property<int>("payment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("payment_Id"));

                    b.Property<int>("AmountPaid")
                        .HasColumnType("int");

                    b.Property<bool>("IsSuccessfull")
                        .HasColumnType("bit");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("payment_Id");

                    b.HasIndex("OrderID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.Rating", b =>
                {
                    b.Property<int>("rating_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("rating_id"));

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<int>("restaurant_id")
                        .HasColumnType("int");

                    b.HasKey("rating_id");

                    b.HasIndex("restaurant_id");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.RestaurantDetails", b =>
                {
                    b.Property<int>("Restaurant_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Restaurant_id"));

                    b.Property<string>("Restaurant_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Restaurant_id");

                    b.ToTable("RestaurantDetails");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.DeliveryDetails", b =>
                {
                    b.HasOne("OnlineFoodDeliverySystem.Models.OrderDetails", "orderDetails")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.MenuItemsList", b =>
                {
                    b.HasOne("OnlineFoodDeliverySystem.Models.RestaurantDetails", "Restaurants")
                        .WithMany()
                        .HasForeignKey("Restaurant_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurants");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.OrderDetails", b =>
                {
                    b.HasOne("OnlineFoodDeliverySystem.Models.CustomUserTable", "user")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.Payment", b =>
                {
                    b.HasOne("OnlineFoodDeliverySystem.Models.OrderDetails", "orderDetails")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("OnlineFoodDeliverySystem.Models.Rating", b =>
                {
                    b.HasOne("OnlineFoodDeliverySystem.Models.RestaurantDetails", "Restaurants")
                        .WithMany()
                        .HasForeignKey("restaurant_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
