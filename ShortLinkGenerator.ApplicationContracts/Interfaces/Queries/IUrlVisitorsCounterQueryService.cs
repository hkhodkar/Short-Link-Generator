using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.ApplicationContracts.Interfaces.Queries
{
    public interface IUrlVisitorsCounterQueryService
    {
        Task<long> GetUrlVisitorsCount(string linkCode);
    }
}
