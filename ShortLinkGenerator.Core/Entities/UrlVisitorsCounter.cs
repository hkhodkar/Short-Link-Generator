using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkGenerator.Core.Entities
{
  public  class UrlVisitorsCounter
    {
        public long CounterId { get; private set; }
        public long Count { get; private set; }
        public Guid LinkCode { get; private set; }
        public DateTime LastVisited { get; private set; }

        public UrlVisitorsCounter()
        {

        }

        public UrlVisitorsCounter(Guid linkCode)
        {
            this.LinkCode = linkCode;
        }
    }
}
