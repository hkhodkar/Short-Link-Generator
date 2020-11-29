using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.DomainContracts.Interfaces.Queries
{
    public interface IUrlVisitorsCounterQueryRepository
    {
        Task<long> GetUrlVisitorsCount();
    }
}
