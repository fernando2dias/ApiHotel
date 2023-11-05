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
    public class ReviewMap : IEntityTypeConfiguration<ReviewEntity>
    {
        public void Configure(EntityTypeBuilder<ReviewEntity> builder)
        {
            builder.ToTable("Review");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.EvaluationStars).IsRequired();

            builder.Property(r => r.CreateAt).IsRequired();

            builder.Property(r => r.Comment).IsRequired();

        }
    }
}
