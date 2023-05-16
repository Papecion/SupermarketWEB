using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupermarketWEB.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Providers_ProviderId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoicePayMode_Invoice_InvoicesId",
                table: "InvoicePayMode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_ProviderId",
                table: "Invoices",
                newName: "IX_Invoices_ProviderId");

            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_DetailId",
                table: "Invoices",
                column: "DetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicePayMode_Invoices_InvoicesId",
                table: "InvoicePayMode",
                column: "InvoicesId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Details_DetailId",
                table: "Invoices",
                column: "DetailId",
                principalTable: "Details",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Providers_ProviderId",
                table: "Invoices",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoicePayMode_Invoices_InvoicesId",
                table: "InvoicePayMode");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Details_DetailId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Providers_ProviderId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_DetailId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "Invoices");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_ProviderId",
                table: "Invoice",
                newName: "IX_Invoice_ProviderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Providers_ProviderId",
                table: "Invoice",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicePayMode_Invoice_InvoicesId",
                table: "InvoicePayMode",
                column: "InvoicesId",
                principalTable: "Invoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
