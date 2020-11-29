using Microsoft.EntityFrameworkCore;
using ShortLinkGenerator.Core.Entities;
using ShortLinkGenerator.EF.Persistence.Contexts.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkGenerator.EF.Persistence.Contexts
{
    public class URLContext : DbContext
    {
        public URLContext(DbContextOptions<URLContext> options) : base(options)
        {}


        public DbSet<Url> Urls { get; set; }
        public DbSet<UrlVisitorsCounter> UrlVisitorsCounters { get; set; }


        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UrlConfigurations());
            modelBuilder.ApplyConfiguration(new UrlVisitorsCounterConfigurations());

        }
        #endregion
    }
}
