using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShortLinkGenerator.DomainContracts.Interfaces.Commamds;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Commands;

namespace ShortLinkGenerator.ApplicationServices.Services.Commands
{
    class UrlCommandService : IUrlCommandService
    {
        private readonly IUrlCommandRepository _urlCommandRepository;

        public UrlCommandService(IUrlCommandRepository urlCommandRepository)
        {
            _urlCommandRepository = urlCommandRepository;
        }
        
        public async Task<long> GenerateLink(string link)
        {
          return await  _urlCommandRepository.AddUrl(link);
        }
    }
}
