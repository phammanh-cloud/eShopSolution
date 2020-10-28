using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configuration
{
    public class HocSinhConfiguration : IEntityTypeConfiguration<HocSinh>
    {
        public void Configure(EntityTypeBuilder<HocSinh> builder)
        {
            builder.ToTable("HocShinhs");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired(true);

            builder.Property(x => x.DateOfBirth).IsRequired(true).HasDefaultValue<DateTime>(DateTime.Now);
        }
    }
}
