using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Venue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("00a4256c-4d4a-48be-8ce7-558f5c4191a6"), "drinks", "London", new DateTime(2024, 8, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9268), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("337f3777-9f9b-4ad4-afea-b541190c2ff3"), "drinks", "London", new DateTime(2024, 9, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9271), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("35cb45cd-4057-41f9-8664-29339a25aedb"), "drinks", "London", new DateTime(2024, 10, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9286), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("371454a8-4245-4a2a-a51c-d69afe926f91"), "travel", "London", new DateTime(2024, 12, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9292), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("656e5b5e-3cd3-4279-b300-6ea3ea996ba0"), "drinks", "London", new DateTime(2024, 3, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9248), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("85dc0ee8-a4a1-466f-8c11-9d1fbe8bdb3f"), "culture", "Paris", new DateTime(2024, 4, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9259), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("c0833967-3e46-4b25-a226-a24a3853790f"), "film", "London", new DateTime(2025, 1, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9295), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("c0aadc51-19ca-434b-b7cf-c5ee9a1c2e1e"), "music", "London", new DateTime(2024, 11, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9290), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("e24f7b94-78ee-460f-acea-860fa9e83e2d"), "culture", "London", new DateTime(2024, 6, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9262), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("ea5a6ef8-aad6-47b6-b14b-0240081ce673"), "music", "London", new DateTime(2024, 7, 2, 14, 27, 28, 867, DateTimeKind.Utc).AddTicks(9265), "Activity 2 months in future", "Future Activity 2", "O2 Arena" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
