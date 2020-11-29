using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ShortLinkGenerator.EF.Persistence.Contexts;
using ShortLinkGenerator.DomainContracts.Interfaces.Commamds;
using ShortLinkGenerator.Core.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ShortLinkGenerator.DomainServices.Services.Commands
{
    public class UrlCommandRepository : IUrlCommandRepository
    {
        private readonly URLContext _context;

        public UrlCommandRepository(URLContext context)
        {
            _context = context;
        }

        public async Task<Url> AddUrl(string link)
        {
            var exitEntity = await GetUrl(link);

            BuildEntity(link, exitEntity, out Url entity);

            _context.Add(entity);

           await _context.SaveChangesAsync();

            return entity;

        }

        #region utilities
        private async Task<Url> GetUrl(string link)
        {
            return await _context.Urls.Where(u => u.Link == link).FirstOrDefaultAsync();
        }

        private Url BuildEntity(string link, Url exitEntity, out Url entity)
        {
            if (exitEntity != null)
            {
                var linkCode = exitEntity.LinkCode;
                entity = CreateUrl(link, linkCode);
            }
            else
            {
                var linkCode = Guid.NewGuid().ToString().Replace("-", "");
                entity = CreateUrl(link, linkCode);
            }

            return entity;
        }

        private string GenerateShortLink(byte length,string link)
        {

            Uri myUri = new Uri(link);
            string host = myUri.Host;
            var shortLink =host + "/L/" + Guid.NewGuid().ToString().Replace("-", "").Substring(0, length);

            while (_context.Urls.Any(s => s.ShortLink == shortLink))
                shortLink =host + "/L/" +Guid.NewGuid().ToString().Replace("-", "").Substring(0, length);

            return shortLink;
        }

        private Url CreateUrl(string link, string linkCode)
        {
            return new Url(link, GenerateShortLink(6,link), linkCode);
        }
        #endregion
    }
}
