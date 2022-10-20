using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x=>  x.CarName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Color).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Wheels).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Headlights).IsRequired();
            
        }
    }
}
