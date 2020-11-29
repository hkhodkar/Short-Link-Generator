using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShortLinkGenerator.DomainContracts.Interfaces.Queries;
using ShortLinkGenerator.EF.Persistence.Contexts;
using ShortLinkGenerator.Core.Entities;

namespace ShortLinkGenerator.DomainServices.Services.Queries
{
    public class UrlQueryRepository : IUrlQueryRepository
    {
        private readonly URLContext _context;

        public UrlQueryRepository(URLContext context)
        {
            _context = context;
        }


        public async Task<string> GetShortLink(long urlId)
        {
            return await _context.Urls.Where(u => u.UrlId == urlId)
                                      .Select(c => c.ShortLink)
                                      .SingleOrDefaultAsync();
        }


        public async Task<Url> GetLinkByShortLink(string shortLink)
        {
            return await _context.Urls.Where(u => u.ShortLink == shortLink)
                                        .SingleOrDefaultAsync();
        }

        public async Task<Url> GetLink(string link)
        {
            return await _context.Urls.Where(c => c.Link == link).FirstOrDefaultAsync();
        }
    }
}
