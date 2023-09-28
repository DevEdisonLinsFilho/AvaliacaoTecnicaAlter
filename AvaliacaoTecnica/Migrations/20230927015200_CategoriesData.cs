using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoTecnica.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {           
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Active" },
                values: new object[] { 1, "Eletrônicos", true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Active" },
                values: new object[] { 2, "Roupas e Moda", true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Active" },
                values: new object[] { 3, "Alimentos e Bebidas", true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Active" },
                values: new object[] { 4, "Mobiliário e Decoração de Interiores", true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Active" },
                values: new object[] { 5, "Saúde e Beleza", true });
            
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 1, "Smartphone", "6x3", 1001, null, 100, 799.99m, true, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 2, "Laptop", "13x9", 1002, null, 50, 1299.99m, true, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 3, "Camiseta", "S, M, L", 2001, null, 200, 29.99m, true, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 4, "Vestido", "S, M, L", 2002, null, 100, 49.99m, true, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 5, "Chocolate", "100g", 3001, null, 500, 4.99m, true, 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 6, "Vinho Tinto", "750ml", 3002, null, 50, 19.99m, true, 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 7, "Sofá", "90x40x30", 4001, null, 20, 499.99m, true, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 8, "Mesa de Jantar", "120x80x75", 4002, null, 10, 299.99m, true, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 9, "Shampoo", "250ml", 5001, null, 100, 7.99m, true, 5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Dimensions", "Code", "Reference", "Stockbalance", "Price", "Active", "CategoryId" },
                values: new object[] { 10, "Creme Facial", "50ml", 5002, null, 50, 14.99m, true, 5 });
        
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
