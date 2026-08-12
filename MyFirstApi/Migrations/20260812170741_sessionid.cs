using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstApi.Migrations
{
    /// <inheritdoc />
    public partial class sessionid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "AccountUsers",
                type: "nvarchar(max)",
                nullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "AccountUsers");

        }
    }
}
