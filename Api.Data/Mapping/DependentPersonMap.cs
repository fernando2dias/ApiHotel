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
    public class DependentPersonMap : IEntityTypeConfiguration<DependentPersonEntity>
    {
        public void Configure(EntityTypeBuilder<DependentPersonEntity> builder)
        {
            builder.ToTable("DependentPerson");

            builder.HasKey(dp => dp.Id);

            builder.Property(dp => dp.Name).IsRequired().HasMaxLength(60);

            builder.Property(dp => dp.LastName).IsRequired().HasMaxLength(60);

            builder.Property(dp => dp.BirthDate).IsRequired();

            builder.Property(dp => dp.CPF).HasMaxLength(14);

            builder.Property(dp => dp.RG).HasMaxLength(11);

            builder.Property(dp => dp.Passport).HasMaxLength(30);

        }
    }
}
