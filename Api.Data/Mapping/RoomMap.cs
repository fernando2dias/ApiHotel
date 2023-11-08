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
    public class RoomMap : IEntityTypeConfiguration<RoomEntity>
    {
        public void Configure(EntityTypeBuilder<RoomEntity> builder)
        {
            builder.ToTable("Room");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.PricePerNight).IsRequired();

            builder.Property(r => r.Number).IsRequired();

            builder.Property(r => r.NumberBeds).IsRequired();

            builder.Property(r => r.HotelId).IsRequired();

        }
    }
}
