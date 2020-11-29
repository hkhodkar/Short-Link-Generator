using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.DomainContracts.Interfaces.Queries
{
    public interface IUrlQueryRepository
    {
        Task<string> GetShortLink(long id);
        Task<string> GetLinkByShortLink(string shortLink);
    }
}
