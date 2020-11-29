using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkGenerator.Core.Entities
{
  public  class UrlVisitorsCounter
    {
        public long CounterId { get; private set; }
        public long Count { get; private set; }
        public string LinkCode { get; private set; }
        public DateTime LastVisited { get; private set; }

        public UrlVisitorsCounter()
        {

        }

        public UrlVisitorsCounter(string linkCode)
        {
            this.LinkCode = linkCode;
        }

        public void CountUp()
        {
            this.Count++;
        }
    }
}
