using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KartverketApplikasjon.Migrations
{
    /// <inheritdoc />
    public partial class SeaTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSeaMapActive",
                table: "MapCorrections",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSeaMapActive",
                table: "GeoChanges",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSeaMapActive",
                table: "MapCorrections");

            migrationBuilder.DropColumn(
                name: "IsSeaMapActive",
                table: "GeoChanges");
        }
    }
}
