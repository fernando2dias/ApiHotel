using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class HotelMap : IEntityTypeConfiguration<HotelEntity>
    {
        public void Configure(EntityTypeBuilder<HotelEntity> builder)
        {
            builder.ToTable("Hotel");

            builder.HasKey(h => h.Id);

            builder.Property(h => h.Name).IsRequired().HasMaxLength(60);

            builder.Property(h => h.Address).IsRequired().HasMaxLength(200);

            builder.Property(h => h.ZipCode).IsRequired().HasMaxLength(8);

            builder.Property(h => h.State).IsRequired().HasMaxLength(2);

            builder.Property(h => h.City).IsRequired().HasMaxLength(30);

            builder.Property(h => h.AvgTicket).IsRequired();

        }
    }
}
