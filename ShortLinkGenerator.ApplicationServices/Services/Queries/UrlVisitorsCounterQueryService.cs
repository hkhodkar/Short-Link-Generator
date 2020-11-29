using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Queries;
using ShortLinkGenerator.DomainContracts.Interfaces.Queries;

namespace ShortLinkGenerator.ApplicationServices.Services.Queries
{
    public class UrlVisitorsCounterQueryService : IUrlVisitorsCounterQueryService
    {
        private IUrlVisitorsCounterQueryRepository _urlVisitorsCounterQueryRepository;

        public UrlVisitorsCounterQueryService(IUrlVisitorsCounterQueryRepository urlVisitorsCounterQueryRepository)
        {
            _urlVisitorsCounterQueryRepository = urlVisitorsCounterQueryRepository;
        }

        public async Task<long> GetUrlVisitorsCount(string linkCode)
        {
            return await _urlVisitorsCounterQueryRepository.GetUrlVisitorsCount(linkCode);
        }
    }
}
