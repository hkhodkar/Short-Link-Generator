using ShortLinkGenerator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.DomainContracts.Interfaces.Queries
{
    public interface IUrlQueryRepository
    {
        Task<string> GetShortLink(long id);
        Task<Url> GetLinkByShortLink(string shortLink);
        Task<Url> GetLink(string link);
    }
}
