using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlankFinance.Migrations
{
    public partial class Budget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    BudgetId = table.Column<Guid>(nullable: false),
                    BudgetXML = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastUsed = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.BudgetId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}
