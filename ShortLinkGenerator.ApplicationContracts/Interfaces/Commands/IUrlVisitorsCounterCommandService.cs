using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShortLinkGenerator.ApplicationContracts.Interfaces.Commands
{
    public interface IUrlVisitorsCounterCommandService
    {
        Task AddCount(string linkCode);
    }
}
