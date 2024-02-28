using BeFit_DATA.Concrete;
using BeFit_DATA.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_REPO.Mapping
{
    public class FoodMapping : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Food");
            builder.HasKey(x => x.ID); //Primary Key
            builder.Property(x => x.ID).HasColumnName("Food ID").HasColumnOrder(1);
            builder.Property(x => x.Name).HasColumnName("Food Name").HasColumnOrder(2).HasColumnType("nvarchar(50)");
            builder.HasOne(x => x.Category).WithMany(x => x.Foods).HasForeignKey(x => x.CategoryID);
            builder.HasMany(x => x.UserFoods).WithOne(x => x.Food).HasForeignKey(x => x.FoodID);
            builder.Property(x => x.Picture).HasColumnType("text");
            builder.Property(x => x.PortionType).HasColumnType("nvarchar(50)");
            builder.HasData(
           new Food { ID = 1, CategoryID = 1, Name = "Artichoke", PortionType = PortionType.Unit, Calorie = 60, Carbohydrate = 13.5, Protein = 3.5, Fat = 0.2 },
 new Food { ID = 2, CategoryID = 1, Name = "Arugula", PortionType = PortionType.Gram, Calorie = 25, Carbohydrate = 3.7, Protein = 2.6, Fat = 0.7 },
 new Food { ID = 3, CategoryID = 1, Name = "Asparagus", PortionType = PortionType.Unit, Calorie = 20, Carbohydrate = 3.9, Protein = 2.2, Fat = 0.2 },
 new Food { ID = 4, CategoryID = 1, Name = "Aubergine", PortionType = PortionType.Unit, Calorie = 24, Carbohydrate = 5.7, Protein = 1.0, Fat = 0.2 },
 new Food { ID = 5, CategoryID = 1, Name = "Beetroot", PortionType = PortionType.Unit, Calorie = 43, Carbohydrate = 9.6, Protein = 1.6, Fat = 0.2 },
 new Food { ID = 6, CategoryID = 1, Name = "Bell Pepper", PortionType = PortionType.Unit, Calorie = 20, Carbohydrate = 4.7, Protein = 0.9, Fat = 0.2 },
 new Food { ID = 7, CategoryID = 1, Name = "Black Olives", PortionType = PortionType.Unit, Calorie = 115, Carbohydrate = 6.3, Protein = 0.8, Fat = 10.7 },
 new Food { ID = 8, CategoryID = 1, Name = "Broccoli", PortionType = PortionType.Gram, Calorie = 34, Carbohydrate = 6.6, Protein = 2.8, Fat = 0.4 },
 new Food { ID = 9, CategoryID = 1, Name = "Brussels Sprouts", PortionType = PortionType.Gram, Calorie = 43, Carbohydrate = 8.9, Protein = 3.4, Fat = 0.3 },
 new Food { ID = 10, CategoryID = 1, Name = "Cabbage", PortionType = PortionType.Floweret, Calorie = 25, Carbohydrate = 5.8, Protein = 1.3, Fat = 0.1 },
 new Food { ID = 11, CategoryID = 1, Name = "Capsicum", PortionType = PortionType.Unit, Calorie = 18, Carbohydrate = 4.3, Protein = 0.9, Fat = 0.2 },
 new Food { ID = 12, CategoryID = 1, Name = "Carrot", PortionType = PortionType.Unit, Calorie = 41, Carbohydrate = 9.6, Protein = 0.9, Fat = 0.2 },
 new Food { ID = 13, CategoryID = 1, Name = "Cauliflower", PortionType = PortionType.Floweret, Calorie = 25, Carbohydrate = 5.0, Protein = 2.0, Fat = 0.1 },
 new Food { ID = 14, CategoryID = 1, Name = "Celery", PortionType = PortionType.Plate, Calorie = 14, Carbohydrate = 3.0, Protein = 0.7, Fat = 0.2 },
 new Food { ID = 15, CategoryID = 1, Name = "Cherry Tomato", PortionType = PortionType.Unit, Calorie = 3, Carbohydrate = 0.7, Protein = 0.2, Fat = 0.0 },
 new Food { ID = 16, CategoryID = 1, Name = "Chinese Cabbage", PortionType = PortionType.Floweret, Calorie = 12, Carbohydrate = 2.2, Protein = 1.2, Fat = 0.2 },
 new Food { ID = 17, CategoryID = 1, Name = "Collard Greens", PortionType = PortionType.Gram, Calorie = 32, Carbohydrate = 5.9, Protein = 3.0, Fat = 0.6 },
 new Food { ID = 18, CategoryID = 1, Name = "Corn", PortionType = PortionType.Unit, Calorie = 123, Carbohydrate = 25.7, Protein = 4.7, Fat = 1.5 },
 new Food { ID = 19, CategoryID = 1, Name = "Courgette", PortionType = PortionType.Gram, Calorie = 17, Carbohydrate = 3.1, Protein = 1.2, Fat = 0.3 },
 new Food { ID = 20, CategoryID = 1, Name = "Cucumber", PortionType = PortionType.Unit, Calorie = 16, Carbohydrate = 3.6, Protein = 0.7, Fat = 0.2 },
 new Food { ID = 21, CategoryID = 11, Name = "Salami", PortionType = PortionType.Gram, Calorie = 336, Carbohydrate = 1.2, Protein = 14.0, Fat = 30.0 },
 new Food { ID = 22, CategoryID = 1, Name = "Endive", PortionType = PortionType.Gram, Calorie = 17, Carbohydrate = 3.4, Protein = 1.3, Fat = 0.2 },
 new Food { ID = 23, CategoryID = 1, Name = "Fennel", PortionType = PortionType.Gram, Calorie = 32, Carbohydrate = 7.3, Protein = 1.2, Fat = 0.2 },
 new Food { ID = 24, CategoryID = 1, Name = "Garlic", PortionType = PortionType.Unit, Calorie = 4, Carbohydrate = 1.0, Protein = 0.2, Fat = 0.0 },
 new Food { ID = 25, CategoryID = 1, Name = "Gherkin", PortionType = PortionType.Unit, Calorie = 9, Carbohydrate = 2.1, Protein = 0.4, Fat = 0.1 },
 new Food { ID = 26, CategoryID = 1, Name = "Gourd", PortionType = PortionType.Unit, Calorie = 108, Carbohydrate = 27.0, Protein = 2.0, Fat = 0.2 },
 new Food { ID = 27, CategoryID = 1, Name = "Green Beans", PortionType = PortionType.Gram, Calorie = 32, Carbohydrate = 7.1, Protein = 1.8, Fat = 0.2 },
 new Food { ID = 28, CategoryID = 1, Name = "Green Olives", PortionType = PortionType.Unit, Calorie = 2, Carbohydrate = 0.3, Protein = 0.2, Fat = 0.2 },
 new Food { ID = 29, CategoryID = 1, Name = "Green Onion", PortionType = PortionType.Unit, Calorie = 5, Carbohydrate = 1.3, Protein = 0.3, Fat = 0.0 },
 new Food { ID = 30, CategoryID = 1, Name = "Horseradish", PortionType = PortionType.Gram, Calorie = 7, Carbohydrate = 1.7, Protein = 0.2, Fat = 0.1 },
 new Food { ID = 31, CategoryID = 1, Name = "Kale", PortionType = PortionType.Gram, Calorie = 43, Carbohydrate = 8.8, Protein = 4.3, Fat = 0.9 },
 new Food { ID = 32, CategoryID = 1, Name = "Leek", PortionType = PortionType.Unit, Calorie = 54, Carbohydrate = 12.6, Protein = 1.5, Fat = 0.3 },
 new Food { ID = 33, CategoryID = 1, Name = "Lettuce", PortionType = PortionType.Unit, Calorie = 109, Carbohydrate = 20.1, Protein = 6.9, Fat = 2.2 },
 new Food { ID = 34, CategoryID = 1, Name = "Mushrooms", PortionType = PortionType.Unit, Calorie = 1, Carbohydrate = 0.2, Protein = 0.1, Fat = 0.0 },
 new Food { ID = 35, CategoryID = 1, Name = "Mustard Greens", PortionType = PortionType.Gram, Calorie = 28, Carbohydrate = 4.7, Protein = 2.9, Fat = 0.4 },
 new Food { ID = 36, CategoryID = 1, Name = "Okra", PortionType = PortionType.Gram, Calorie = 33, Carbohydrate = 7.5, Protein = 2.0, Fat = 0.2 },
 new Food { ID = 37, CategoryID = 11, Name = "Sausage", PortionType = PortionType.Gram, Calorie = 300, Carbohydrate = 1.0, Protein = 14.0, Fat = 26.0 },
 new Food { ID = 38, CategoryID = 1, Name = "Onion", PortionType = PortionType.Unit, Calorie = 34, Carbohydrate = 7.9, Protein = 1.1, Fat = 0.1 },
 new Food { ID = 39, CategoryID = 1, Name = "Parsnips", PortionType = PortionType.Unit, Calorie = 128, Carbohydrate = 30.2, Protein = 2.1, Fat = 0.6 },
 new Food { ID = 40, CategoryID = 1, Name = "Peas", PortionType = PortionType.Gram, Calorie = 81, Carbohydrate = 14.5, Protein = 5.4, Fat = 0.4 },
 new Food { ID = 41, CategoryID = 11, Name = "Bacon", PortionType = PortionType.Slice, Calorie = 29, Carbohydrate = 0.1, Protein = 3, Fat = 2 },
 new Food { ID = 42, CategoryID = 1, Name = "Potato", PortionType = PortionType.Unit, Calorie = 164, Carbohydrate = 37, Protein = 4.3, Fat = 0.2 },
 new Food { ID = 43, CategoryID = 1, Name = "Pumpkin", PortionType = PortionType.Unit, Calorie = 51, Carbohydrate = 12, Protein = 2, Fat = 0.1 },
 new Food { ID = 44, CategoryID = 1, Name = "Radishes", PortionType = PortionType.Unit, Calorie = 15, Carbohydrate = 3.4, Protein = 0.7, Fat = 0.1 },
 new Food { ID = 45, CategoryID = 1, Name = "Red Cabbage", PortionType = PortionType.Unit, Calorie = 260, Carbohydrate = 62, Protein = 12, Fat = 1.5 },
 new Food { ID = 46, CategoryID = 1, Name = "Rutabaga", PortionType = PortionType.Unit, Calorie = 147, Carbohydrate = 35, Protein = 4.1, Fat = 0.5 },
 new Food { ID = 47, CategoryID = 1, Name = "Shallots", PortionType = PortionType.Unit, Calorie = 18, Carbohydrate = 4.2, Protein = 0.8, Fat = 0.1 },
 new Food { ID = 48, CategoryID = 1, Name = "Squash", PortionType = PortionType.Unit, Calorie = 130, Carbohydrate = 31, Protein = 3, Fat = 1.4 },
 new Food { ID = 49, CategoryID = 1, Name = "Sweet Potato", PortionType = PortionType.Unit, Calorie = 112, Carbohydrate = 26, Protein = 2, Fat = 0.1 },
 new Food { ID = 50, CategoryID = 1, Name = "Tomato", PortionType = PortionType.Unit, Calorie = 20, Carbohydrate = 4.7, Protein = 1, Fat = 0.2 },
 new Food { ID = 51, CategoryID = 1, Name = "Turnip", PortionType = PortionType.Unit, Calorie = 34, Carbohydrate = 7.9, Protein = 1.1, Fat = 0.1 },
 new Food { ID = 52, CategoryID = 2, Name = "Apple", PortionType = PortionType.Unit, Calorie = 95, Carbohydrate = 25.1, Protein = 0.5, Fat = 0.3 },
 new Food { ID = 53, CategoryID = 2, Name = "Apricot", PortionType = PortionType.Unit, Calorie = 17, Carbohydrate = 3.9, Protein = 0.5, Fat = 0.1 },
 new Food { ID = 54, CategoryID = 2, Name = "Avocado", PortionType = PortionType.Unit, Calorie = 240, Carbohydrate = 12.8, Protein = 3, Fat = 22 },
 new Food { ID = 55, CategoryID = 2, Name = "Banana", PortionType = PortionType.Unit, Calorie = 111, Carbohydrate = 28.8, Protein = 1.3, Fat = 0.3 },
 new Food { ID = 56, CategoryID = 2, Name = "Blackberries", PortionType = PortionType.Gram, Calorie = 43, Carbohydrate = 9.8, Protein = 1.4, Fat = 0.5 },
 new Food { ID = 57, CategoryID = 2, Name = "Blood Oranges", PortionType = PortionType.Unit, Calorie = 70, Carbohydrate = 16.2, Protein = 1.3, Fat = 0.3 },
 new Food { ID = 58, CategoryID = 2, Name = "Blueberries", PortionType = PortionType.Gram, Calorie = 84, Carbohydrate = 21.4, Protein = 1.1, Fat = 0.5 },
 new Food { ID = 59, CategoryID = 2, Name = "Cantaloupe", PortionType = PortionType.Gram, Calorie = 34, Carbohydrate = 8.2, Protein = 0.8, Fat = 0.2 },
 new Food { ID = 60, CategoryID = 2, Name = "Cherries", PortionType = PortionType.Unit, Calorie = 4, Carbohydrate = 1.0, Protein = 0.1, Fat = 0.0 },
 new Food { ID = 61, CategoryID = 2, Name = "Cranberries", PortionType = PortionType.Gram, Calorie = 46, Carbohydrate = 12.2, Protein = 0.4, Fat = 0.1 },
 new Food { ID = 62, CategoryID = 2, Name = "Dates", PortionType = PortionType.Unit, Calorie = 20, Carbohydrate = 5.3, Protein = 0.2, Fat = 0.0 },
 new Food { ID = 63, CategoryID = 2, Name = "Figs", PortionType = PortionType.Unit, Calorie = 37, Carbohydrate = 9.6, Protein = 0.4, Fat = 0.2 },
 new Food { ID = 64, CategoryID = 7, Name = "Fruit salad", PortionType = PortionType.Bowl, Calorie = 125, Carbohydrate = 30.5, Protein = 2.5, Fat = 0.5 },
 new Food { ID = 65, CategoryID = 2, Name = "Grapes", PortionType = PortionType.Gram, Calorie = 67, Carbohydrate = 17.3, Protein = 0.6, Fat = 0.4 },
 new Food { ID = 66, CategoryID = 2, Name = "Kiwi", PortionType = PortionType.Unit, Calorie = 112, Carbohydrate = 26.3, Protein = 2.1, Fat = 0.5 },
 new Food { ID = 67, CategoryID = 2, Name = "Lemon", PortionType = PortionType.Unit, Calorie = 17, Carbohydrate = 5.4, Protein = 0.6, Fat = 0.2 },
 new Food { ID = 68, CategoryID = 2, Name = "Lime", PortionType = PortionType.Unit, Calorie = 20, Carbohydrate = 6.9, Protein = 0.5, Fat = 0.1 },
 new Food { ID = 69, CategoryID = 2, Name = "Lychees", PortionType = PortionType.Unit, Calorie = 7, Carbohydrate = 1.7, Protein = 0.1, Fat = 0.0 },
 new Food { ID = 70, CategoryID = 2, Name = "Mandarin Oranges", PortionType = PortionType.Unit, Calorie = 47, Carbohydrate = 11.7, Protein = 0.7, Fat = 0.3 },
 new Food { ID = 71, CategoryID = 2, Name = "Mango", PortionType = PortionType.Unit, Calorie = 202, Carbohydrate = 50.3, Protein = 2.8, Fat = 1.3 },
 new Food { ID = 72, CategoryID = 2, Name = "Nectarine", PortionType = PortionType.Unit, Calorie = 66, Carbohydrate = 15.8, Protein = 1.6, Fat = 0.4 },
 new Food { ID = 73, CategoryID = 2, Name = "Orange", PortionType = PortionType.Unit, Calorie = 62, Carbohydrate = 15.5, Protein = 1.2, Fat = 0.2 },
 new Food { ID = 74, CategoryID = 2, Name = "Papaya", PortionType = PortionType.Unit, Calorie = 215, Carbohydrate = 55.3, Protein = 2.5, Fat = 1.3 },
 new Food { ID = 75, CategoryID = 2, Name = "Passion Fruit", PortionType = PortionType.Unit, Calorie = 17, Carbohydrate = 4.2, Protein = 0.4, Fat = 0.1 },
 new Food { ID = 76, CategoryID = 2, Name = "Peach", PortionType = PortionType.Unit, Calorie = 59, Carbohydrate = 14.8, Protein = 1.4, Fat = 0.4 },
 new Food { ID = 77, CategoryID = 2, Name = "Pear", PortionType = PortionType.Unit, Calorie = 101, Carbohydrate = 27.1, Protein = 0.6, Fat = 0.3 },
 new Food { ID = 78, CategoryID = 2, Name = "Pineapple", PortionType = PortionType.Gram, Calorie = 50, Carbohydrate = 13.1, Protein = 0.5, Fat = 0.1 },
 new Food { ID = 79, CategoryID = 2, Name = "Plum", PortionType = PortionType.Unit, Calorie = 30, Carbohydrate = 7.9, Protein = 0.5, Fat = 0.2 },
 new Food { ID = 80, CategoryID = 2, Name = "Pomegranate", PortionType = PortionType.Unit, Calorie = 234, Carbohydrate = 58.8, Protein = 4.7, Fat = 3.3 },
 new Food { ID = 81, CategoryID = 5, Name = "Raisins", PortionType = PortionType.Gram, Calorie = 300, Carbohydrate = 79.2, Protein = 3.1, Fat = 0.5 },
 new Food { ID = 82, CategoryID = 2, Name = "Raspberries", PortionType = PortionType.Bowl, Calorie = 64, Carbohydrate = 14.7, Protein = 1.5, Fat = 0.8 },
 new Food { ID = 83, CategoryID = 2, Name = "Strawberries", PortionType = PortionType.Bowl, Calorie = 49, Carbohydrate = 11.7, Protein = 1.0, Fat = 0.5 },
 new Food { ID = 84, CategoryID = 2, Name = "Tangerine", PortionType = PortionType.Unit, Calorie = 47, Carbohydrate = 11.7, Protein = 0.7, Fat = 0.3 },
 new Food { ID = 85, CategoryID = 2, Name = "Watermelon", PortionType = PortionType.Slice, Calorie = 86, Carbohydrate = 21.6, Protein = 1.7, Fat = 0.4 },
 new Food { ID = 86, CategoryID = 8, Name = "Bacon and Eggs", PortionType = PortionType.Serving, Calorie = 680, Carbohydrate = 1.1, Protein = 37.0, Fat = 61.5 },
 new Food { ID = 87, CategoryID = 12, Name = "Baked Beans", PortionType = PortionType.Gram, Calorie = 150, Carbohydrate = 22.1, Protein = 9.5, Fat = 0.5 },
 new Food { ID = 88, CategoryID = 11, Name = "BBQ Ribs", PortionType = PortionType.Unit, Calorie = 360, Carbohydrate = 0.0, Protein = 24.0, Fat = 30.0 },
 new Food { ID = 89, CategoryID = 11, Name = "Beef Stew", PortionType = PortionType.Bowl, Calorie = 186, Carbohydrate = 11.4, Protein = 18.3, Fat = 7.2 },
 new Food { ID = 90, CategoryID = 12, Name = "Black Rice", PortionType = PortionType.Gram, Calorie = 170, Carbohydrate = 36.7, Protein = 3.5, Fat = 1.5 },
 new Food { ID = 91, CategoryID = 12, Name = "Brown Rice", PortionType = PortionType.Gram, Calorie = 110, Carbohydrate = 22.8, Protein = 2.6, Fat = 0.9 },
 new Food { ID = 92, CategoryID = 10, Name = "Burrito", PortionType = PortionType.Unit, Calorie = 326, Carbohydrate = 31.3, Protein = 13.2, Fat = 16.0 },
 new Food { ID = 93, CategoryID = 9, Name = "California Roll", PortionType = PortionType.Unit, Calorie = 33, Carbohydrate = 6.0, Protein = 1.0, Fat = 0.7 },
 new Food { ID = 94, CategoryID = 7, Name = "Chicken Caesar Salad", PortionType = PortionType.Bowl, Calorie = 309, Carbohydrate = 12.0, Protein = 23.4, Fat = 20.5 },
 new Food { ID = 95, CategoryID = 11, Name = "Chicken Marsala", PortionType = PortionType.Serving, Calorie = 290, Carbohydrate = 8.4, Protein = 28.1, Fat = 14.8 },
 new Food { ID = 96, CategoryID = 11, Name = "Chicken Tikka Masala", PortionType = PortionType.Serving, Calorie = 350, Carbohydrate = 13.0, Protein = 25.0, Fat = 22.0 },
 new Food { ID = 97, CategoryID = 11, Name = "Chimichanga", PortionType = PortionType.Unit, Calorie = 308, Carbohydrate = 32.0, Protein = 15.0, Fat = 14.0 },
 new Food { ID = 98, CategoryID = 7, Name = "Cobb Salad", PortionType = PortionType.Bowl, Calorie = 160, Carbohydrate = 10.0, Protein = 12.0, Fat = 8.0 },
 new Food { ID = 99, CategoryID = 10, Name = "Corn Dog", PortionType = PortionType.Unit, Calorie = 180, Carbohydrate = 18.0, Protein = 7.0, Fat = 10.0 },
 new Food { ID = 100, CategoryID = 6, Name = "Cottage Pie", PortionType = PortionType.Slice, Calorie = 300, Carbohydrate = 23.0, Protein = 17.0, Fat = 15.0 },
 new Food { ID = 101, CategoryID = 9, Name = "Crab Cake", PortionType = PortionType.Unit, Calorie = 285, Carbohydrate = 19.0, Protein = 17.0, Fat = 16.0 },
 new Food { ID = 102, CategoryID = 5, Name = "Creme Brulee", PortionType = PortionType.Unit, Calorie = 321, Carbohydrate = 33.0, Protein = 4.0, Fat = 19.0 },
 new Food { ID = 103, CategoryID = 11, Name = "Croissant", PortionType = PortionType.Unit, Calorie = 406, Carbohydrate = 45.0, Protein = 8.0, Fat = 23.0 },
 new Food { ID = 104, CategoryID = 10, Name = "Cupcake", PortionType = PortionType.Unit, Calorie = 131, Carbohydrate = 20.0, Protein = 1.0, Fat = 5.0 },
 new Food { ID = 105, CategoryID = 6, Name = "Dumplings", PortionType = PortionType.Piece, Calorie = 40, Carbohydrate = 5.0, Protein = 2.0, Fat = 1.0 },
 new Food { ID = 106, CategoryID = 5, Name = "Eclair", PortionType = PortionType.Unit, Calorie = 220, Carbohydrate = 23.0, Protein = 4.0, Fat = 14.0 },
 new Food { ID = 107, CategoryID = 2, Name = "Egg", PortionType = PortionType.Unit, Calorie = 68, Carbohydrate = 0.6, Protein = 5.5, Fat = 4.8 },
 new Food { ID = 108, CategoryID = 3, Name = "Fried Chicken", PortionType = PortionType.Piece, Calorie = 160, Carbohydrate = 7.0, Protein = 10.0, Fat = 11.0 },
 new Food { ID = 109, CategoryID = 11, Name = "Fried Rice", PortionType = PortionType.Gram, Calorie = 130, Carbohydrate = 26.0, Protein = 2.0, Fat = 1.0 },
 new Food { ID = 110, CategoryID = 7, Name = "Granola Bar", PortionType = PortionType.Unit, Calorie = 118, Carbohydrate = 19.0, Protein = 2.0, Fat = 4.0 },
 new Food { ID = 111, CategoryID = 5, Name = "Ice Cream", PortionType = PortionType.Unit, Calorie = 267, Carbohydrate = 33.0, Protein = 3.5, Fat = 14.0 },
 new Food { ID = 112, CategoryID = 11, Name = "Muffin", PortionType = PortionType.Unit, Calorie = 265, Carbohydrate = 38.0, Protein = 3.0, Fat = 12.0 },
 new Food { ID = 113, CategoryID = 7, Name = "Oatmeal", PortionType = PortionType.Gram, Calorie = 71, Carbohydrate = 12.0, Protein = 2.5, Fat = 1.5 },
 new Food { ID = 114, CategoryID = 9, Name = "Pancake", PortionType = PortionType.Unit, Calorie = 159, Carbohydrate = 29.0, Protein = 3.0, Fat = 3.5 },
 new Food { ID = 115, CategoryID = 10, Name = "Pizza", PortionType = PortionType.Slice, Calorie = 285, Carbohydrate = 36.0, Protein = 11.0, Fat = 10.0 },
 new Food { ID = 116, CategoryID = 8, Name = "Popcorn", PortionType = PortionType.Gram, Calorie = 365, Carbohydrate = 77.0, Protein = 9.0, Fat = 4.0 },
 new Food { ID = 117, CategoryID = 6, Name = "Sushi", PortionType = PortionType.Piece, Calorie = 37, Carbohydrate = 7.0, Protein = 1.0, Fat = 0.4 },
 new Food { ID = 118, CategoryID = 3, Name = "Salmon", PortionType = PortionType.Gram, Calorie = 206, Carbohydrate = 0.0, Protein = 22.0, Fat = 13.4 },
 new Food { ID = 119, CategoryID = 3, Name = "Tuna", PortionType = PortionType.Gram, Calorie = 144, Carbohydrate = 0.0, Protein = 30.0, Fat = 1.0 },
 new Food { ID = 120, CategoryID = 3, Name = "Shrimp", PortionType = PortionType.Gram, Calorie = 85, Carbohydrate = 0.0, Protein = 20.0, Fat = 0.9 },
 new Food { ID = 121, CategoryID = 3, Name = "Lamb Chop", PortionType = PortionType.Gram, Calorie = 250, Carbohydrate = 0.0, Protein = 25.0, Fat = 17.0 },
 new Food { ID = 122, CategoryID = 4, Name = "Sweet Corn", PortionType = PortionType.Gram, Calorie = 86, Carbohydrate = 19.0, Protein = 3.0, Fat = 1.2 },
 new Food { ID = 123, CategoryID = 1, Name = "Zucchini", PortionType = PortionType.Gram, Calorie = 17, Carbohydrate = 3.1, Protein = 1.2, Fat = 0.2 },
 new Food { ID = 124, CategoryID = 1, Name = "Spinach", PortionType = PortionType.Gram, Calorie = 23, Carbohydrate = 3.6, Protein = 2.9, Fat = 0.4 },
 new Food { ID = 125, CategoryID = 2, Name = "Cherry", PortionType = PortionType.Gram, Calorie = 50, Carbohydrate = 12.0, Protein = 1.0, Fat = 0.3 },
 new Food { ID = 126, CategoryID = 2, Name = "Blueberry", PortionType = PortionType.Gram, Calorie = 29, Carbohydrate = 7.4, Protein = 0.7, Fat = 0.2 },
 new Food { ID = 127, CategoryID = 2, Name = "Strawberry", PortionType = PortionType.Gram, Calorie = 32, Carbohydrate = 7.7, Protein = 0.7, Fat = 0.3 },
 new Food { ID = 128, CategoryID = 1, Name = "Radish", PortionType = PortionType.Gram, Calorie = 16, Carbohydrate = 3.4, Protein = 0.7, Fat = 0.1 },
 new Food { ID = 129, CategoryID = 2, Name = "Blackberry", PortionType = PortionType.Gram, Calorie = 43, Carbohydrate = 9.6, Protein = 2.0, Fat = 0.5 },
 new Food { ID = 130, CategoryID = 2, Name = "Raspberry", PortionType = PortionType.Gram, Calorie = 52, Carbohydrate = 11.9, Protein = 1.5, Fat = 0.7 },
 new Food { ID = 131, CategoryID = 1, Name = "Eggplant", PortionType = PortionType.Gram, Calorie = 25, Carbohydrate = 6.0, Protein = 1.0, Fat = 0.2 });


        }

    }
}
