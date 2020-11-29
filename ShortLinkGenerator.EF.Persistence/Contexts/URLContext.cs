using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkGenerator.EF.Persistence.Contexts
{
    public class URLContext : DbContext
    {
        public URLContext( DbContextOptions<URLContext> options ) : base(options)
        {

        }
    }
}
