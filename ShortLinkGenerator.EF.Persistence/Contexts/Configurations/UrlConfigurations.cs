using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShortLinkGenerator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkGenerator.EF.Persistence.Contexts.Configurations
{
    public class UrlConfigurations : IEntityTypeConfiguration<Url>
    {
        public void Configure(EntityTypeBuilder<Url> builder)
        {
            builder.ToTable("Url", "URL");
            builder.HasKey(b => b.UrlId);
            builder.Property(b => b.Link)
                   .IsRequired();

            builder.Property(b => b.CreatedDate)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("(getdate())");

            builder.Property(b => b.ShortLink)
                   .HasMaxLength(100)
                   .IsRequired(true);
        }
    }
}
