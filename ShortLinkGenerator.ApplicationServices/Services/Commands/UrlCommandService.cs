using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShortLinkGenerator.DomainContracts.Interfaces.Commamds;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Commands;
using ShortLinkGenerator.Core.Entities;
using ShortLinkGenerator.ApplicationContracts.DTOs;
using ShortLinkGenerator.ApplicationServices.Mapper;

namespace ShortLinkGenerator.ApplicationServices.Services.Commands
{
  public  class UrlCommandService : IUrlCommandService
    {
        private readonly IUrlCommandRepository _urlCommandRepository;

        public UrlCommandService(IUrlCommandRepository urlCommandRepository)
        {
            _urlCommandRepository = urlCommandRepository;
        }
        
        public async Task<UrlDto> GenerateLink(string link)
        {
          var entity = await  _urlCommandRepository.AddUrl(link);

            return UrLMapper.Map(entity);
        }
    }
}
