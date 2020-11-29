using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShortLinkGenerator.ApplicationContracts.DTOs;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Queries;
using ShortLinkGenerator.ApplicationServices.Mapper;
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

        public async Task<UrlDto> GetLinkByShortLink(string shortLink)
        {
            var entity = await _urlQueryRepository.GetLinkByShortLink(shortLink);
            if (entity == null)
                return null;
            return UrLMapper.Map(entity);
        }

        public async Task<UrlDto> GetLink(string link)
        {
            var entity =await _urlQueryRepository.GetLink(link);
            if (entity == null)
                return null;
            else
            {
                return UrLMapper.Map(entity);

            }

        }
    }
}
