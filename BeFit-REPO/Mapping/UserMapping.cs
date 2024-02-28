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
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasColumnOrder(1);
            builder.Property(x => x.Name).HasColumnName("First Name").HasColumnOrder(2).HasColumnType("nvarchar(30)");
            builder.Property(x => x.LastName).HasColumnName("Last Name").HasColumnOrder(3).HasColumnType("nvarchar(30)");
            builder.Property(x => x.Password).HasColumnOrder(4).HasColumnType("nvarchar(20)");
            builder.Property(x => x.UserMail).HasColumnOrder(5).HasColumnType("nvarchar(50)");
            builder.Property(x => x.Phone).HasColumnOrder(6).HasColumnType("nvarchar(15)");            
            builder.HasMany(x => x.UserFoods).WithOne(x => x.User).HasForeignKey(x => x.UserID);
            builder.Property(x => x.TrainingLevel).HasColumnType("nvarchar(50)");
            builder.Property(x => x.Status).HasColumnType("nvarchar(20)");
            builder.Property(x => x.Gender).HasColumnType("nvarchar(20)");
        }
    }
}
