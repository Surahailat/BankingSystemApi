using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingSystemApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Server_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTime_UTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IBAN_Hash = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IBAN_Encrypted = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IBAN_Mask = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Update_DateTime_UTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    IP_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Source_IP_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Host_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Client_Time_Zone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Geo_Coordinates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Source_App = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Source_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Session_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Auth_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Auth_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");
        }
    }
}
