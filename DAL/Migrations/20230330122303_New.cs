using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageProduct_Product_productId",
                table: "ImageProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_PaymentMethod_paymentMethodId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_userid",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_categoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfCart_Product_productId",
                table: "ProductsOfCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfCart_Users_userid",
                table: "ProductsOfCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfCategory_Category_categoryId",
                table: "ProductsOfCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfCategory_Product_productId",
                table: "ProductsOfCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfOrder_Order_orderId",
                table: "ProductsOfOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Product_productId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Users_userid",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_VouchersOfOrder_Order_orderId",
                table: "VouchersOfOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_VouchersOfOrder_Voucher_voucherId",
                table: "VouchersOfOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VouchersOfOrder",
                table: "VouchersOfOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voucher",
                table: "Voucher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsOfOrder",
                table: "ProductsOfOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsOfCategory",
                table: "ProductsOfCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsOfCart",
                table: "ProductsOfCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageProduct",
                table: "ImageProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "VouchersOfOrder",
                newName: "VouchersOfOrders");

            migrationBuilder.RenameTable(
                name: "Voucher",
                newName: "Vouchers");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "ProductsOfOrder",
                newName: "ProductsOfOrders");

            migrationBuilder.RenameTable(
                name: "ProductsOfCategory",
                newName: "ProductsOfCategories");

            migrationBuilder.RenameTable(
                name: "ProductsOfCart",
                newName: "ProductsOfCarts");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PaymentMethod",
                newName: "PaymentMethods");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "ImageProduct",
                newName: "ImageProducts");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_VouchersOfOrder_voucherId",
                table: "VouchersOfOrders",
                newName: "IX_VouchersOfOrders_voucherId");

            migrationBuilder.RenameIndex(
                name: "IX_VouchersOfOrder_orderId",
                table: "VouchersOfOrders",
                newName: "IX_VouchersOfOrders_orderId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_userid",
                table: "Reviews",
                newName: "IX_Reviews_userid");

            migrationBuilder.RenameIndex(
                name: "IX_Review_productId",
                table: "Reviews",
                newName: "IX_Reviews_productId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfOrder_orderId",
                table: "ProductsOfOrders",
                newName: "IX_ProductsOfOrders_orderId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfCategory_productId",
                table: "ProductsOfCategories",
                newName: "IX_ProductsOfCategories_productId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfCategory_categoryId",
                table: "ProductsOfCategories",
                newName: "IX_ProductsOfCategories_categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfCart_userid",
                table: "ProductsOfCarts",
                newName: "IX_ProductsOfCarts_userid");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfCart_productId",
                table: "ProductsOfCarts",
                newName: "IX_ProductsOfCarts_productId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_categoryId",
                table: "Products",
                newName: "IX_Products_categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_userid",
                table: "Orders",
                newName: "IX_Orders_userid");

            migrationBuilder.RenameIndex(
                name: "IX_Order_paymentMethodId",
                table: "Orders",
                newName: "IX_Orders_paymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_ImageProduct_productId",
                table: "ImageProducts",
                newName: "IX_ImageProducts_productId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VouchersOfOrders",
                table: "VouchersOfOrders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vouchers",
                table: "Vouchers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsOfOrders",
                table: "ProductsOfOrders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsOfCategories",
                table: "ProductsOfCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsOfCarts",
                table: "ProductsOfCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageProducts",
                table: "ImageProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageProducts_Products_productId",
                table: "ImageProducts",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_paymentMethodId",
                table: "Orders",
                column: "paymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_userid",
                table: "Orders",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfCarts_Products_productId",
                table: "ProductsOfCarts",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfCarts_Users_userid",
                table: "ProductsOfCarts",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfCategories_Categories_categoryId",
                table: "ProductsOfCategories",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfCategories_Products_productId",
                table: "ProductsOfCategories",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfOrders_Orders_orderId",
                table: "ProductsOfOrders",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_productId",
                table: "Reviews",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_userid",
                table: "Reviews",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VouchersOfOrders_Orders_orderId",
                table: "VouchersOfOrders",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VouchersOfOrders_Vouchers_voucherId",
                table: "VouchersOfOrders",
                column: "voucherId",
                principalTable: "Vouchers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageProducts_Products_productId",
                table: "ImageProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentMethods_paymentMethodId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_userid",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfCarts_Products_productId",
                table: "ProductsOfCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfCarts_Users_userid",
                table: "ProductsOfCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfCategories_Categories_categoryId",
                table: "ProductsOfCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfCategories_Products_productId",
                table: "ProductsOfCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOfOrders_Orders_orderId",
                table: "ProductsOfOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_productId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_userid",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_VouchersOfOrders_Orders_orderId",
                table: "VouchersOfOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_VouchersOfOrders_Vouchers_voucherId",
                table: "VouchersOfOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VouchersOfOrders",
                table: "VouchersOfOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vouchers",
                table: "Vouchers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsOfOrders",
                table: "ProductsOfOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsOfCategories",
                table: "ProductsOfCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsOfCarts",
                table: "ProductsOfCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageProducts",
                table: "ImageProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "VouchersOfOrders",
                newName: "VouchersOfOrder");

            migrationBuilder.RenameTable(
                name: "Vouchers",
                newName: "Voucher");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "ProductsOfOrders",
                newName: "ProductsOfOrder");

            migrationBuilder.RenameTable(
                name: "ProductsOfCategories",
                newName: "ProductsOfCategory");

            migrationBuilder.RenameTable(
                name: "ProductsOfCarts",
                newName: "ProductsOfCart");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "PaymentMethods",
                newName: "PaymentMethod");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "ImageProducts",
                newName: "ImageProduct");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_VouchersOfOrders_voucherId",
                table: "VouchersOfOrder",
                newName: "IX_VouchersOfOrder_voucherId");

            migrationBuilder.RenameIndex(
                name: "IX_VouchersOfOrders_orderId",
                table: "VouchersOfOrder",
                newName: "IX_VouchersOfOrder_orderId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_userid",
                table: "Review",
                newName: "IX_Review_userid");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_productId",
                table: "Review",
                newName: "IX_Review_productId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfOrders_orderId",
                table: "ProductsOfOrder",
                newName: "IX_ProductsOfOrder_orderId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfCategories_productId",
                table: "ProductsOfCategory",
                newName: "IX_ProductsOfCategory_productId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfCategories_categoryId",
                table: "ProductsOfCategory",
                newName: "IX_ProductsOfCategory_categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfCarts_userid",
                table: "ProductsOfCart",
                newName: "IX_ProductsOfCart_userid");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOfCarts_productId",
                table: "ProductsOfCart",
                newName: "IX_ProductsOfCart_productId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryId",
                table: "Product",
                newName: "IX_Product_categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_userid",
                table: "Order",
                newName: "IX_Order_userid");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_paymentMethodId",
                table: "Order",
                newName: "IX_Order_paymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_ImageProducts_productId",
                table: "ImageProduct",
                newName: "IX_ImageProduct_productId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VouchersOfOrder",
                table: "VouchersOfOrder",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voucher",
                table: "Voucher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsOfOrder",
                table: "ProductsOfOrder",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsOfCategory",
                table: "ProductsOfCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsOfCart",
                table: "ProductsOfCart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageProduct",
                table: "ImageProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageProduct_Product_productId",
                table: "ImageProduct",
                column: "productId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_PaymentMethod_paymentMethodId",
                table: "Order",
                column: "paymentMethodId",
                principalTable: "PaymentMethod",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_userid",
                table: "Order",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_categoryId",
                table: "Product",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfCart_Product_productId",
                table: "ProductsOfCart",
                column: "productId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfCart_Users_userid",
                table: "ProductsOfCart",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfCategory_Category_categoryId",
                table: "ProductsOfCategory",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfCategory_Product_productId",
                table: "ProductsOfCategory",
                column: "productId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfOrder_Order_orderId",
                table: "ProductsOfOrder",
                column: "orderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Product_productId",
                table: "Review",
                column: "productId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Users_userid",
                table: "Review",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VouchersOfOrder_Order_orderId",
                table: "VouchersOfOrder",
                column: "orderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VouchersOfOrder_Voucher_voucherId",
                table: "VouchersOfOrder",
                column: "voucherId",
                principalTable: "Voucher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
