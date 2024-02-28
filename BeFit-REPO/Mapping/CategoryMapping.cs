using BeFit_DATA.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_REPO.Mapping
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasColumnName("Category ID").HasColumnOrder(1);
            builder.Property(x => x.Name).HasColumnName("Category Name").HasColumnOrder(2).HasColumnType("nvarchar(50)");
            builder.HasData(
                    new Category { ID = 1, Name = "Vegetable" },
                    new Category { ID = 2, Name = "Fruit" },
                    new Category { ID = 3, Name = "Soft Drink" },
                    new Category { ID = 4, Name = "Alcohol" },
                    new Category { ID = 5, Name = "Snack" },
                    new Category { ID = 6, Name = "Dessert" },
                    new Category { ID = 7, Name = "Salad" },
                    new Category { ID = 8, Name = "Dairy" },
                    new Category { ID = 9, Name = "Fish and Seafood" },
                    new Category { ID = 10, Name = "Fast Food" },
                    new Category { ID = 11, Name = "Meat or Poultry" },
                    new Category { ID = 12, Name = "Grain, Bean and Nuts" },
                    new Category { ID = 13, Name = "Others" }
                );          
        }
    }
}
