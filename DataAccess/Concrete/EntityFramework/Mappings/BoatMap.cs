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
    public class BoatMap : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.ToTable("Boats");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.BoatName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Color).IsRequired().HasMaxLength(100);
        }
    }
}
