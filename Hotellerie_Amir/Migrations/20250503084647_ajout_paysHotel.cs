using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotellerie_Amir.Migrations
{
    /// <inheritdoc />
    public partial class ajout_paysHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pays",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Tunisie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pays",
                table: "Hotels");
        }
    }
}
