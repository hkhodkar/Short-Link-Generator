using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ShortLinkGenerator.Core.Entities;

namespace ShortLinkGenerator.DomainContracts.Interfaces.Commamds
{
  public  interface IUrlCommandRepository
    {
        Task<long> AddUrl(string link);
    }
}
