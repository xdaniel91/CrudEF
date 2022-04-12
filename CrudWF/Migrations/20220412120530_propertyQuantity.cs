using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudWF.Migrations
{
    public partial class propertyQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvaliableQuantity",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvaliableQuantity",
                table: "Products");
        }
    }
}
