using ShortLinkGenerator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.ApplicationContracts.Interfaces.Commands
{
    public interface IUrlCommandService
    {
        Task<Url> GenerateLink(string link);
    }
}
