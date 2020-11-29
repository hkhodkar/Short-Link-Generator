using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.ApplicationContracts.Interfaces.Commands
{
    public interface IUrlCommandService
    {
        Task<long> GenerateLink(string link);
    }
}
