﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantBookingWebApi.Data;

#nullable disable

namespace RestaurantBookingWebApi.Migrations
{
    [DbContext(typeof(RestaurantBookingContext))]
    [Migration("20240425140259_changedcolumncompulsaryinbooking")]
    partial class changedcolumncompulsaryinbooking
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantBookingWebApi.Models.RestaurantBookingDetails", b =>
                {
                    b.Property<int>("bookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookingId"));

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("restaurantId")
                        .HasColumnType("int");

                    b.Property<string>("startTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tableNo")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("bookingId");

                    b.HasIndex("restaurantId");

                    b.HasIndex("userId");

                    b.ToTable("RestaurantBookingDetails");
                });

            modelBuilder.Entity("RestaurantBookingWebApi.Models.RestaurantList", b =>
                {
                    b.Property<int>("restaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("restaurantId"));

                    b.Property<string>("about")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("rating")
                        .HasColumnType("real");

                    b.HasKey("restaurantId");

                    b.ToTable("RestaurantList");
                });

            modelBuilder.Entity("RestaurantBookingWebApi.Models.UserList", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("UserList");
                });

            modelBuilder.Entity("RestaurantBookingWebApi.Models.RestaurantBookingDetails", b =>
                {
                    b.HasOne("RestaurantBookingWebApi.Models.RestaurantList", "RestaurantList")
                        .WithMany()
                        .HasForeignKey("restaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantBookingWebApi.Models.UserList", "UserList")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RestaurantList");

                    b.Navigation("UserList");
                });
#pragma warning restore 612, 618
        }
    }
}
