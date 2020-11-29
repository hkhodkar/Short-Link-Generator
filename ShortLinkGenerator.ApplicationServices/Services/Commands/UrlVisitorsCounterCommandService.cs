using System;
using System.Text;
using System.Collections.Generic;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Commands;
using System.Threading.Tasks;
using ShortLinkGenerator.DomainContracts.Interfaces.Commamds;

namespace ShortLinkGenerator.ApplicationServices.Services.Commands
{
    public class UrlVisitorsCounterCommandService : IUrlVisitorsCounterCommandService
    {
        private readonly IUrlVisitorsCounterCommandRepository _urlVisitorsCounterCommandRepository;

        public UrlVisitorsCounterCommandService( IUrlVisitorsCounterCommandRepository urlVisitorsCounterCommandRepository)
        {
            _urlVisitorsCounterCommandRepository = urlVisitorsCounterCommandRepository;
        }
        public async Task AddCount(string linkCode)
        {
            await _urlVisitorsCounterCommandRepository.AddCounter(linkCode);
        }
    }
}
