using Api.Domain.Entities;
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
    public class CustomerMap : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(c => c.Id);

            builder.HasIndex(c => c.Email).IsUnique();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(60);
            
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(60);

            builder.Property(c => c.BirthDate).IsRequired();

            builder.Property(c => c.CPF).HasMaxLength(14);

            builder.Property(c => c.RG).HasMaxLength(11);

            builder.Property(c => c.Passport).HasMaxLength(30);

            builder.Property(c => c.Password).IsRequired().HasMaxLength(20);
        }
    }
}
