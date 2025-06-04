using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceDashboard.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_IncomeTemplates_UserId",
                table: "IncomeTemplates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeInstances_UserId_EstimatedReceivedDate",
                table: "IncomeInstances",
                columns: new[] { "UserId", "EstimatedReceivedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_BillTemplates_UserId",
                table: "BillTemplates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BillInstances_UserId_EstimatedDueDate",
                table: "BillInstances",
                columns: new[] { "UserId", "EstimatedDueDate" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_IncomeTemplates_UserId",
                table: "IncomeTemplates");

            migrationBuilder.DropIndex(
                name: "IX_IncomeInstances_UserId_EstimatedReceivedDate",
                table: "IncomeInstances");

            migrationBuilder.DropIndex(
                name: "IX_BillTemplates_UserId",
                table: "BillTemplates");

            migrationBuilder.DropIndex(
                name: "IX_BillInstances_UserId_EstimatedDueDate",
                table: "BillInstances");
        }
    }
}
