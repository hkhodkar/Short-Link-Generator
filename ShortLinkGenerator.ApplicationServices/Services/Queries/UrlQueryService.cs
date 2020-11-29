using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Queries;
using ShortLinkGenerator.Core.Entities;
using ShortLinkGenerator.DomainContracts.Interfaces.Queries;

namespace ShortLinkGenerator.ApplicationServices.Services.Queries
{
    public class UrlQueryService : IUrlQueryService
    {
        private readonly IUrlQueryRepository _urlQueryRepository;

        public UrlQueryService(IUrlQueryRepository urlQueryRepository)
        {
            _urlQueryRepository = urlQueryRepository;
        }


        public async Task<string> GetShortLink(long id)
        {
           return await _urlQueryRepository.GetShortLink(id);
        }

        public async Task<Url> GetLinkByShortLink(string shortLink)
        {
            return await _urlQueryRepository.GetLinkByShortLink(shortLink);
        }

        public async Task<Url> GetLink(string link)
        {
            return await _urlQueryRepository.GetLink(link);
        }
    }
}
