using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DreamWedds.PersistenceLayer.Repository.Migrations.DreamWeddsDB
{
    public partial class InitialDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_SubscriptionMasters_SubscrptionId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWeddingSubscriptions_OrderMasters_InvoiceNoNavigationId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWeddingSubscriptions_SubscriptionMasters_SubscriptionTypeNavigationId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_UserWeddingSubscriptions_InvoiceNoNavigationId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_UserWeddingSubscriptions_SubscriptionTypeNavigationId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_SubscrptionId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "InvoiceNoNavigationId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropColumn(
                name: "SubscriptionTypeNavigationId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropColumn(
                name: "Cgst",
                table: "OrderMasters");

            migrationBuilder.DropColumn(
                name: "OderNote",
                table: "OrderMasters");

            migrationBuilder.DropColumn(
                name: "Sgst",
                table: "OrderMasters");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "UserWeddingSubscriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UserWeddingSubscriptions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "UserWeddingSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "UserWeddingSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderMasterId",
                table: "UserWeddingSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionMasterId",
                table: "UserWeddingSubscriptions",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReceivedAmount",
                table: "OrderMasters",
                type: "decimal(9, 2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMode",
                table: "OrderMasters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "OrderMasters",
                type: "decimal(9, 2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "OrderMasters",
                type: "decimal(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "Gst",
                table: "OrderMasters",
                type: "decimal(9, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "OrderNote",
                table: "OrderMasters",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderDetails",
                type: "decimal(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "OrderDetails",
                type: "decimal(9, 2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OrderDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "OrderDetails",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "OrderDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionId",
                table: "OrderDetails",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CommonSetup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainType = table.Column<string>(nullable: true),
                    SubType = table.Column<string>(nullable: true),
                    DisplayText = table.Column<string>(nullable: true),
                    DisplayValue = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonSetup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    ContactFor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscriptions_OrderMasterId",
                table: "UserWeddingSubscriptions",
                column: "OrderMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscriptions_SubscriptionMasterId",
                table: "UserWeddingSubscriptions",
                column: "SubscriptionMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SubscriptionId",
                table: "OrderDetails",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_SubscriptionMasters_SubscriptionId",
                table: "OrderDetails",
                column: "SubscriptionId",
                principalTable: "SubscriptionMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWeddingSubscriptions_OrderMasters_OrderMasterId",
                table: "UserWeddingSubscriptions",
                column: "OrderMasterId",
                principalTable: "OrderMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWeddingSubscriptions_SubscriptionMasters_SubscriptionMasterId",
                table: "UserWeddingSubscriptions",
                column: "SubscriptionMasterId",
                principalTable: "SubscriptionMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_SubscriptionMasters_SubscriptionId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWeddingSubscriptions_OrderMasters_OrderMasterId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWeddingSubscriptions_SubscriptionMasters_SubscriptionMasterId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropTable(
                name: "CommonSetup");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropIndex(
                name: "IX_UserWeddingSubscriptions_OrderMasterId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_UserWeddingSubscriptions_SubscriptionMasterId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_SubscriptionId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropColumn(
                name: "OrderMasterId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropColumn(
                name: "SubscriptionMasterId",
                table: "UserWeddingSubscriptions");

            migrationBuilder.DropColumn(
                name: "Gst",
                table: "OrderMasters");

            migrationBuilder.DropColumn(
                name: "OrderNote",
                table: "OrderMasters");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceNoNavigationId",
                table: "UserWeddingSubscriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionTypeNavigationId",
                table: "UserWeddingSubscriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReceivedAmount",
                table: "OrderMasters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMode",
                table: "OrderMasters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "OrderMasters",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "OrderMasters",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)");

            migrationBuilder.AddColumn<int>(
                name: "Cgst",
                table: "OrderMasters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OderNote",
                table: "OrderMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sgst",
                table: "OrderMasters",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)");

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscriptions_InvoiceNoNavigationId",
                table: "UserWeddingSubscriptions",
                column: "InvoiceNoNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscriptions_SubscriptionTypeNavigationId",
                table: "UserWeddingSubscriptions",
                column: "SubscriptionTypeNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SubscrptionId",
                table: "OrderDetails",
                column: "SubscrptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_SubscriptionMasters_SubscrptionId",
                table: "OrderDetails",
                column: "SubscrptionId",
                principalTable: "SubscriptionMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWeddingSubscriptions_OrderMasters_InvoiceNoNavigationId",
                table: "UserWeddingSubscriptions",
                column: "InvoiceNoNavigationId",
                principalTable: "OrderMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWeddingSubscriptions_SubscriptionMasters_SubscriptionTypeNavigationId",
                table: "UserWeddingSubscriptions",
                column: "SubscriptionTypeNavigationId",
                principalTable: "SubscriptionMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
