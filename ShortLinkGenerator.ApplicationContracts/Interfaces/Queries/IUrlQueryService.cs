using ShortLinkGenerator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.ApplicationContracts.Interfaces.Queries
{
    public interface IUrlQueryService
    {
        Task<string> GetShortLink(long id);
        Task<Url> GetLinkByShortLink(string shortLink);
    }
}
