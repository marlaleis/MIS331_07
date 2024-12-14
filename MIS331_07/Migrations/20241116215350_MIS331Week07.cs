using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MIS331_07.Migrations
{
    /// <inheritdoc />
    public partial class MIS331Week07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Item = table.Column<string>(type: "text", nullable: false),
                    UOM = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: false),
                    OriginalPrice = table.Column<double>(type: "double precision", nullable: false),
                    Discount = table.Column<double>(type: "double precision", nullable: false),
                    ExtendedPrice = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceLists", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PriceLists",
                columns: new[] { "Id", "Amount", "Brand", "Date", "Discount", "ExtendedPrice", "Item", "OriginalPrice", "UOM" },
                values: new object[] { 1, 450.0, "Your Fresh Market", new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Utc), 0.0, 7.4800000000000004, "Lean Ground Beef", 7.4800000000000004, "grams" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceLists");
        }
    }
}
