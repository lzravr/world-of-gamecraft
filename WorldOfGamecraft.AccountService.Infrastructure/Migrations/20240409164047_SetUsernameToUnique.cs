using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldOfGamecraft.AccountService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SetUsernameToUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_accounts_username",
                table: "accounts",
                column: "username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_accounts_username",
                table: "accounts");
        }
    }
}
