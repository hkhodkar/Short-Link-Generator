using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShortLinkGenerator.DomainContracts.Interfaces.Queries;
using ShortLinkGenerator.EF.Persistence.Contexts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ShortLinkGenerator.DomainServices.Services.Queries
{
    public class UrlVisitorsCounterQueryRepository : IUrlVisitorsCounterQueryRepository
    {
        private readonly URLContext _context;

        public UrlVisitorsCounterQueryRepository(URLContext context)
        {
            _context = context;
        }

        public async Task<long> GetUrlVisitorsCount(string linkCode)
        {
            return await _context.UrlVisitorsCounters.Where(u => u.LinkCode == linkCode)
                                                       .Select(u => u.Count)
                                                       .FirstOrDefaultAsync();
        }
    }
}
