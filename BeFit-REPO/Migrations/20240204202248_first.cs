using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeFit_REPO.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(name: "Category ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(name: "Category Name", type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First Name", type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(name: "Last Name", type: "nvarchar(30)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UserMail = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    TrainingLevel = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BodyMassIndex = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodID = table.Column<int>(name: "Food ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(name: "Food Name", type: "nvarchar(50)", nullable: false),
                    PortionType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Calorie = table.Column<double>(type: "float", nullable: false),
                    Fat = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Carbohydrate = table.Column<double>(type: "float", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Food_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "Category ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User Food",
                columns: table => new
                {
                    UserFoodID = table.Column<int>(name: "User Food ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealType = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    TotalCalorie = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User Food", x => x.UserFoodID);
                    table.ForeignKey(
                        name: "FK_User Food_Food_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Food",
                        principalColumn: "Food ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User Food_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Category ID", "Category Name" },
                values: new object[,]
                {
                    { 1, "Vegetable" },
                    { 2, "Fruit" },
                    { 3, "Soft drink" },
                    { 4, "Alcohol" },
                    { 5, "Snack" },
                    { 6, "Dessert" },
                    { 7, "Salad" },
                    { 8, "Dairy" },
                    { 9, "Fish and seafood" },
                    { 10, "Fast food" },
                    { 11, "Meat or poultry" },
                    { 12, "Grain, bean and nuts" },
                    { 13, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Food ID", "Calorie", "Carbohydrate", "CategoryID", "Fat", "Food Name", "Picture", "PortionType", "Protein" },
                values: new object[,]
                {
                    { 1, 60.0, 13.5, 1, 0.20000000000000001, "Artichoke", null, "Unit", 3.5 },
                    { 2, 25.0, 3.7000000000000002, 1, 0.69999999999999996, "Arugula", null, "Gram", 2.6000000000000001 },
                    { 3, 20.0, 3.8999999999999999, 1, 0.20000000000000001, "Asparagus", null, "Unit", 2.2000000000000002 },
                    { 4, 24.0, 5.7000000000000002, 1, 0.20000000000000001, "Aubergine", null, "Unit", 1.0 },
                    { 5, 43.0, 9.5999999999999996, 1, 0.20000000000000001, "Beetroot", null, "Unit", 1.6000000000000001 },
                    { 6, 20.0, 4.7000000000000002, 1, 0.20000000000000001, "Bell pepper", null, "Unit", 0.90000000000000002 },
                    { 7, 115.0, 6.2999999999999998, 1, 10.699999999999999, "Black olives", null, "Unit", 0.80000000000000004 },
                    { 8, 34.0, 6.5999999999999996, 1, 0.40000000000000002, "Broccoli", null, "Gram", 2.7999999999999998 },
                    { 9, 43.0, 8.9000000000000004, 1, 0.29999999999999999, "Brussels sprouts", null, "Gram", 3.3999999999999999 },
                    { 10, 25.0, 5.7999999999999998, 1, 0.10000000000000001, "Cabbage", null, "Floweret", 1.3 },
                    { 11, 18.0, 4.2999999999999998, 1, 0.20000000000000001, "Capsicum", null, "Unit", 0.90000000000000002 },
                    { 12, 41.0, 9.5999999999999996, 1, 0.20000000000000001, "Carrot", null, "Unit", 0.90000000000000002 },
                    { 13, 25.0, 5.0, 1, 0.10000000000000001, "Cauliflower", null, "Floweret", 2.0 },
                    { 14, 14.0, 3.0, 1, 0.20000000000000001, "Celery", null, "Plate", 0.69999999999999996 },
                    { 15, 3.0, 0.69999999999999996, 1, 0.0, "Cherry tomato", null, "Unit", 0.20000000000000001 },
                    { 16, 12.0, 2.2000000000000002, 1, 0.20000000000000001, "Chinese cabbage", null, "Floweret", 1.2 },
                    { 17, 32.0, 5.9000000000000004, 1, 0.59999999999999998, "Collard greens", null, "Gram", 3.0 },
                    { 18, 123.0, 25.699999999999999, 1, 1.5, "Corn", null, "Unit", 4.7000000000000002 },
                    { 19, 17.0, 3.1000000000000001, 1, 0.29999999999999999, "Courgette", null, "Gram", 1.2 },
                    { 20, 16.0, 3.6000000000000001, 1, 0.20000000000000001, "Cucumber", null, "Unit", 0.69999999999999996 },
                    { 21, 336.0, 1.2, 11, 30.0, "Salami", null, "Gram", 14.0 },
                    { 22, 17.0, 3.3999999999999999, 1, 0.20000000000000001, "Endive", null, "Gram", 1.3 },
                    { 23, 32.0, 7.2999999999999998, 1, 0.20000000000000001, "Fennel", null, "Gram", 1.2 },
                    { 24, 4.0, 1.0, 1, 0.0, "Garlic", null, "Unit", 0.20000000000000001 },
                    { 25, 9.0, 2.1000000000000001, 1, 0.10000000000000001, "Gherkin", null, "Unit", 0.40000000000000002 },
                    { 26, 108.0, 27.0, 1, 0.20000000000000001, "Gourd", null, "Unit", 2.0 },
                    { 27, 32.0, 7.0999999999999996, 1, 0.20000000000000001, "Green beans", null, "Gram", 1.8 },
                    { 28, 2.0, 0.29999999999999999, 1, 0.20000000000000001, "Green olives", null, "Unit", 0.20000000000000001 },
                    { 29, 5.0, 1.3, 1, 0.0, "Green onion", null, "Unit", 0.29999999999999999 },
                    { 30, 7.0, 1.7, 1, 0.10000000000000001, "Horseradish", null, "Gram", 0.20000000000000001 },
                    { 31, 43.0, 8.8000000000000007, 1, 0.90000000000000002, "Kale", null, "Gram", 4.2999999999999998 },
                    { 32, 54.0, 12.6, 1, 0.29999999999999999, "Leek", null, "Unit", 1.5 },
                    { 33, 109.0, 20.100000000000001, 1, 2.2000000000000002, "Lettuce", null, "Unit", 6.9000000000000004 },
                    { 34, 1.0, 0.20000000000000001, 1, 0.0, "Mushrooms", null, "Unit", 0.10000000000000001 },
                    { 35, 28.0, 4.7000000000000002, 1, 0.40000000000000002, "Mustard greens", null, "Gram", 2.8999999999999999 },
                    { 36, 33.0, 7.5, 1, 0.20000000000000001, "Okra", null, "Gram", 2.0 },
                    { 37, 300.0, 1.0, 11, 26.0, "Sausage", null, "Gram", 14.0 },
                    { 38, 34.0, 7.9000000000000004, 1, 0.10000000000000001, "Onion", null, "Unit", 1.1000000000000001 },
                    { 39, 128.0, 30.199999999999999, 1, 0.59999999999999998, "Parsnips", null, "Unit", 2.1000000000000001 },
                    { 40, 81.0, 14.5, 1, 0.40000000000000002, "Peas", null, "Gram", 5.4000000000000004 },
                    { 41, 29.0, 0.10000000000000001, 11, 2.0, "Bacon", null, "Slice", 3.0 },
                    { 42, 164.0, 37.0, 1, 0.20000000000000001, "Potato", null, "Unit", 4.2999999999999998 },
                    { 43, 51.0, 12.0, 1, 0.10000000000000001, "Pumpkin", null, "Unit", 2.0 },
                    { 44, 15.0, 3.3999999999999999, 1, 0.10000000000000001, "Radishes", null, "Unit", 0.69999999999999996 },
                    { 45, 260.0, 62.0, 1, 1.5, "Red cabbage", null, "Unit", 12.0 },
                    { 46, 147.0, 35.0, 1, 0.5, "Rutabaga", null, "Unit", 4.0999999999999996 },
                    { 47, 18.0, 4.2000000000000002, 1, 0.10000000000000001, "Shallots", null, "Unit", 0.80000000000000004 },
                    { 48, 130.0, 31.0, 1, 1.3999999999999999, "Squash", null, "Unit", 3.0 },
                    { 49, 112.0, 26.0, 1, 0.10000000000000001, "Sweet potato", null, "Unit", 2.0 },
                    { 50, 20.0, 4.7000000000000002, 1, 0.20000000000000001, "Tomato", null, "Unit", 1.0 },
                    { 51, 34.0, 7.9000000000000004, 1, 0.10000000000000001, "Turnip", null, "Unit", 1.1000000000000001 },
                    { 52, 95.0, 25.100000000000001, 2, 0.29999999999999999, "Apple", null, "Unit", 0.5 },
                    { 53, 17.0, 3.8999999999999999, 2, 0.10000000000000001, "Apricot", null, "Unit", 0.5 },
                    { 54, 240.0, 12.800000000000001, 2, 22.0, "Avocado", null, "Unit", 3.0 },
                    { 55, 111.0, 28.800000000000001, 2, 0.29999999999999999, "Banana", null, "Unit", 1.3 },
                    { 56, 43.0, 9.8000000000000007, 2, 0.5, "Blackberries", null, "Gram", 1.3999999999999999 },
                    { 57, 70.0, 16.199999999999999, 2, 0.29999999999999999, "Blood oranges", null, "Unit", 1.3 },
                    { 58, 84.0, 21.399999999999999, 2, 0.5, "Blueberries", null, "Gram", 1.1000000000000001 },
                    { 59, 34.0, 8.1999999999999993, 2, 0.20000000000000001, "Cantaloupe", null, "Gram", 0.80000000000000004 },
                    { 60, 4.0, 1.0, 2, 0.0, "Cherries", null, "Unit", 0.10000000000000001 },
                    { 61, 46.0, 12.199999999999999, 2, 0.10000000000000001, "Cranberries", null, "Gram", 0.40000000000000002 },
                    { 62, 20.0, 5.2999999999999998, 2, 0.0, "Dates", null, "Unit", 0.20000000000000001 },
                    { 63, 37.0, 9.5999999999999996, 2, 0.20000000000000001, "Figs", null, "Unit", 0.40000000000000002 },
                    { 64, 125.0, 30.5, 7, 0.5, "Fruit salad", null, "Bowl", 2.5 },
                    { 65, 67.0, 17.300000000000001, 2, 0.40000000000000002, "Grapes", null, "Gram", 0.59999999999999998 },
                    { 66, 112.0, 26.300000000000001, 2, 0.5, "Kiwi", null, "Unit", 2.1000000000000001 },
                    { 67, 17.0, 5.4000000000000004, 2, 0.20000000000000001, "Lemon", null, "Unit", 0.59999999999999998 },
                    { 68, 20.0, 6.9000000000000004, 2, 0.10000000000000001, "Lime", null, "Unit", 0.5 },
                    { 69, 7.0, 1.7, 2, 0.0, "Lychees", null, "Unit", 0.10000000000000001 },
                    { 70, 47.0, 11.699999999999999, 2, 0.29999999999999999, "Mandarin oranges", null, "Unit", 0.69999999999999996 },
                    { 71, 202.0, 50.299999999999997, 2, 1.3, "Mango", null, "Unit", 2.7999999999999998 },
                    { 72, 66.0, 15.800000000000001, 2, 0.40000000000000002, "Nectarine", null, "Unit", 1.6000000000000001 },
                    { 73, 62.0, 15.5, 2, 0.20000000000000001, "Orange", null, "Unit", 1.2 },
                    { 74, 215.0, 55.299999999999997, 2, 1.3, "Papaya", null, "Unit", 2.5 },
                    { 75, 17.0, 4.2000000000000002, 2, 0.10000000000000001, "Passion fruit", null, "Unit", 0.40000000000000002 },
                    { 76, 59.0, 14.800000000000001, 2, 0.40000000000000002, "Peach", null, "Unit", 1.3999999999999999 },
                    { 77, 101.0, 27.100000000000001, 2, 0.29999999999999999, "Pear", null, "Unit", 0.59999999999999998 },
                    { 78, 50.0, 13.1, 2, 0.10000000000000001, "Pineapple", null, "Gram", 0.5 },
                    { 79, 30.0, 7.9000000000000004, 2, 0.20000000000000001, "Plum", null, "Unit", 0.5 },
                    { 80, 234.0, 58.799999999999997, 2, 3.2999999999999998, "Pomegranate", null, "Unit", 4.7000000000000002 },
                    { 81, 300.0, 79.200000000000003, 5, 0.5, "Raisins", null, "Gram", 3.1000000000000001 },
                    { 82, 64.0, 14.699999999999999, 2, 0.80000000000000004, "Raspberries", null, "Bowl", 1.5 },
                    { 83, 49.0, 11.699999999999999, 2, 0.5, "Strawberries", null, "Bowl", 1.0 },
                    { 84, 47.0, 11.699999999999999, 2, 0.29999999999999999, "Tangerine", null, "Unit", 0.69999999999999996 },
                    { 85, 86.0, 21.600000000000001, 2, 0.40000000000000002, "Watermelon", null, "Slice", 1.7 },
                    { 86, 680.0, 1.1000000000000001, 8, 61.5, "Bacon and eggs", null, "Serving", 37.0 },
                    { 87, 150.0, 22.100000000000001, 12, 0.5, "Baked beans", null, "Gram", 9.5 },
                    { 88, 360.0, 0.0, 11, 30.0, "Bbq ribs", null, "Unit", 24.0 },
                    { 89, 186.0, 11.4, 11, 7.2000000000000002, "Beef stew", null, "Bowl", 18.300000000000001 },
                    { 90, 170.0, 36.700000000000003, 12, 1.5, "Black rice", null, "Gram", 3.5 },
                    { 91, 110.0, 22.800000000000001, 12, 0.90000000000000002, "Brown rice", null, "Gram", 2.6000000000000001 },
                    { 92, 326.0, 31.300000000000001, 10, 16.0, "Burrito", null, "Unit", 13.199999999999999 },
                    { 93, 33.0, 6.0, 9, 0.69999999999999996, "California roll", null, "Unit", 1.0 },
                    { 94, 309.0, 12.0, 7, 20.5, "Chicken caesar salad", null, "Bowl", 23.399999999999999 },
                    { 95, 290.0, 8.4000000000000004, 11, 14.800000000000001, "Chicken marsala", null, "Serving", 28.100000000000001 },
                    { 96, 350.0, 13.0, 11, 22.0, "Chicken tikka masala", null, "Serving", 25.0 },
                    { 97, 308.0, 32.0, 11, 14.0, "Chimichanga", null, "Unit", 15.0 },
                    { 98, 160.0, 10.0, 7, 8.0, "Cobb salad", null, "Bowl", 12.0 },
                    { 99, 180.0, 18.0, 10, 10.0, "Corn dog", null, "Unit", 7.0 },
                    { 100, 300.0, 23.0, 6, 15.0, "Cottage pie", null, "Slice", 17.0 },
                    { 101, 285.0, 19.0, 9, 16.0, "Crab cake", null, "Unit", 17.0 },
                    { 102, 321.0, 33.0, 5, 19.0, "Creme brulee", null, "Unit", 4.0 },
                    { 103, 406.0, 45.0, 11, 23.0, "Croissant", null, "Unit", 8.0 },
                    { 104, 131.0, 20.0, 10, 5.0, "Cupcake", null, "Unit", 1.0 },
                    { 105, 40.0, 5.0, 6, 1.0, "Dumplings", null, "Piece", 2.0 },
                    { 106, 220.0, 23.0, 5, 14.0, "Eclair", null, "Unit", 4.0 },
                    { 107, 68.0, 0.59999999999999998, 2, 4.7999999999999998, "Egg", null, "Unit", 5.5 },
                    { 108, 160.0, 7.0, 3, 11.0, "Fried chicken", null, "Piece", 10.0 },
                    { 109, 130.0, 26.0, 11, 1.0, "Fried rice", null, "Gram", 2.0 },
                    { 110, 118.0, 19.0, 7, 4.0, "Granola bar", null, "Unit", 2.0 },
                    { 111, 267.0, 33.0, 5, 14.0, "Ice cream", null, "Unit", 3.5 },
                    { 112, 265.0, 38.0, 11, 12.0, "Muffin", null, "Unit", 3.0 },
                    { 113, 71.0, 12.0, 7, 1.5, "Oatmeal", null, "Gram", 2.5 },
                    { 114, 159.0, 29.0, 9, 3.5, "Pancake", null, "Unit", 3.0 },
                    { 115, 285.0, 36.0, 10, 10.0, "Pizza", null, "Slice", 11.0 },
                    { 116, 365.0, 77.0, 8, 4.0, "Popcorn", null, "Gram", 9.0 },
                    { 117, 37.0, 7.0, 6, 0.40000000000000002, "Sushi", null, "Piece", 1.0 },
                    { 118, 206.0, 0.0, 3, 13.4, "Salmon", null, "Gram", 22.0 },
                    { 119, 144.0, 0.0, 3, 1.0, "Tuna", null, "Gram", 30.0 },
                    { 120, 85.0, 0.0, 3, 0.90000000000000002, "Shrimp", null, "Gram", 20.0 },
                    { 121, 250.0, 0.0, 3, 17.0, "Lamb chop", null, "Gram", 25.0 },
                    { 122, 86.0, 19.0, 4, 1.2, "Sweet corn", null, "Gram", 3.0 },
                    { 123, 17.0, 3.1000000000000001, 1, 0.20000000000000001, "Zucchini", null, "Gram", 1.2 },
                    { 124, 23.0, 3.6000000000000001, 1, 0.40000000000000002, "Spinach", null, "Gram", 2.8999999999999999 },
                    { 125, 50.0, 12.0, 2, 0.29999999999999999, "Cherry", null, "Gram", 1.0 },
                    { 126, 29.0, 7.4000000000000004, 2, 0.20000000000000001, "Blueberry", null, "Gram", 0.69999999999999996 },
                    { 127, 32.0, 7.7000000000000002, 2, 0.29999999999999999, "Strawberry", null, "Gram", 0.69999999999999996 },
                    { 128, 16.0, 3.3999999999999999, 1, 0.10000000000000001, "Radish", null, "Gram", 0.69999999999999996 },
                    { 129, 43.0, 9.5999999999999996, 2, 0.5, "Blackberry", null, "Gram", 2.0 },
                    { 130, 52.0, 11.9, 2, 0.69999999999999996, "Raspberry", null, "Gram", 1.5 },
                    { 131, 25.0, 6.0, 1, 0.20000000000000001, "Eggplant", null, "Gram", 1.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_CategoryID",
                table: "Food",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_User Food_FoodID",
                table: "User Food",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_User Food_UserID",
                table: "User Food",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User Food");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
