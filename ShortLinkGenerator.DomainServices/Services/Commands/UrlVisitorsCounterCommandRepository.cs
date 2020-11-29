using Microsoft.EntityFrameworkCore;
using ShortLinkGenerator.DomainContracts.Interfaces.Commamds;
using ShortLinkGenerator.EF.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.DomainServices.Services.Commands
{
    public class UrlVisitorsCounterCommandRepository : IUrlVisitorsCounterCommandRepository
    {
        private readonly URLContext _context;

        public UrlVisitorsCounterCommandRepository(URLContext context)
        {
            _context = context;
        }

        public async Task AddCounter(string linkCode)
        {
            var entity = await _context.UrlVisitorsCounters.Where(l => l.LinkCode == linkCode).FirstOrDefaultAsync();
            entity.CountUp();

            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
