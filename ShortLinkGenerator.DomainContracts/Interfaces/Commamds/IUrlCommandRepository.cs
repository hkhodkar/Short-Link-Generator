using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.DomainContracts.Interfaces.Commamds
{
  public  interface IUrlCommandRepository
    {
        Task<string> AddUrl(string Link);
    }
}
