﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240502142729_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Domain.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Venue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("656e5b5e-3cd3-4279-b300-6ea3ea996ba0"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2024, 3, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9248),
                            Description = "Activity 2 months ago",
                            Title = "Past Activity 1",
                            Venue = "Pub"
                        },
                        new
                        {
                            Id = new Guid("85dc0ee8-a4a1-466f-8c11-9d1fbe8bdb3f"),
                            Category = "culture",
                            City = "Paris",
                            Date = new DateTime(2024, 4, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9259),
                            Description = "Activity 1 month ago",
                            Title = "Past Activity 2",
                            Venue = "Louvre"
                        },
                        new
                        {
                            Id = new Guid("e24f7b94-78ee-460f-acea-860fa9e83e2d"),
                            Category = "culture",
                            City = "London",
                            Date = new DateTime(2024, 6, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9262),
                            Description = "Activity 1 month in future",
                            Title = "Future Activity 1",
                            Venue = "Natural History Museum"
                        },
                        new
                        {
                            Id = new Guid("ea5a6ef8-aad6-47b6-b14b-0240081ce673"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2024, 7, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9265),
                            Description = "Activity 2 months in future",
                            Title = "Future Activity 2",
                            Venue = "O2 Arena"
                        },
                        new
                        {
                            Id = new Guid("00a4256c-4d4a-48be-8ce7-558f5c4191a6"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2024, 8, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9268),
                            Description = "Activity 3 months in future",
                            Title = "Future Activity 3",
                            Venue = "Another pub"
                        },
                        new
                        {
                            Id = new Guid("337f3777-9f9b-4ad4-afea-b541190c2ff3"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2024, 9, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9271),
                            Description = "Activity 4 months in future",
                            Title = "Future Activity 4",
                            Venue = "Yet another pub"
                        },
                        new
                        {
                            Id = new Guid("35cb45cd-4057-41f9-8664-29339a25aedb"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2024, 10, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9286),
                            Description = "Activity 5 months in future",
                            Title = "Future Activity 5",
                            Venue = "Just another pub"
                        },
                        new
                        {
                            Id = new Guid("c0aadc51-19ca-434b-b7cf-c5ee9a1c2e1e"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2024, 11, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9290),
                            Description = "Activity 6 months in future",
                            Title = "Future Activity 6",
                            Venue = "Roundhouse Camden"
                        },
                        new
                        {
                            Id = new Guid("371454a8-4245-4a2a-a51c-d69afe926f91"),
                            Category = "travel",
                            City = "London",
                            Date = new DateTime(2024, 12, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9292),
                            Description = "Activity 2 months ago",
                            Title = "Future Activity 7",
                            Venue = "Somewhere on the Thames"
                        },
                        new
                        {
                            Id = new Guid("c0833967-3e46-4b25-a226-a24a3853790f"),
                            Category = "film",
                            City = "London",
                            Date = new DateTime(2025, 1, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9295),
                            Description = "Activity 8 months in future",
                            Title = "Future Activity 8",
                            Venue = "Cinema"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
