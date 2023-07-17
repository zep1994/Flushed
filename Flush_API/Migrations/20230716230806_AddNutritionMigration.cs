using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Flushed_API.Migrations
{
    /// <inheritdoc />
    public partial class AddNutritionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Nutrition",
              columns: table => new
              {
                  Id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  Queryable = table.Column<string>(type: "text", nullable: false),
                  Calories = table.Column<int>(type: "integer", nullable: true),
                  Cuisine = table.Column<string>(type: "text", nullable: true),
                  Diet = table.Column<string>(type: "text", nullable: true),
                  Intolerance = table.Column<int>(type: "text", nullable: true),
                  IncludeIngredients = table.Column<string>(type: "text", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Nutrition", x => x.Id);
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutrition");
        }
    }
}
