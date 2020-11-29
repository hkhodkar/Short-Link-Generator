using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShortLinkGenerator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkGenerator.EF.Persistence.Contexts.Configurations
{
    public class UrlVisitorsCounterConfigurations : IEntityTypeConfiguration<UrlVisitorsCounter>
    {
        public void Configure(EntityTypeBuilder<UrlVisitorsCounter> builder)
        {
            builder.ToTable("UrlVisitorsCounters", "URL");
            builder.HasKey(b => b.CounterId);

            builder.Property(b => b.LastVisited)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("(getdate())");
        }
    }
}
