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
    public class ReservationMap : IEntityTypeConfiguration<ReservationEntity>
    {
        public void Configure(EntityTypeBuilder<ReservationEntity> builder)
        {
            builder.ToTable("Reservation");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.ReserveDateInit).IsRequired();

            builder.Property(r => r.ReserveDateEnd).IsRequired();

        }
    }
}
