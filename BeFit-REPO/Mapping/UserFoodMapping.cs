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
    public class UserFoodMapping : IEntityTypeConfiguration<UserFood>
    {
        public void Configure(EntityTypeBuilder<UserFood> builder)
        {
            builder.ToTable("User Food");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasColumnName("User Food ID").HasColumnOrder(1);
            builder.Property(x => x.MealType).HasColumnType("nvarchar(30)");


        }
    }
}
