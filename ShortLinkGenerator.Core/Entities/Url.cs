using System;
using System.Text;
using System.Collections.Generic;

namespace ShortLinkGenerator.Core.Entities
{
    public class Url
    {
        public long UrlId { get; private set; }
        public string Link { get; private set; }
        public Guid LinkCode { get; private set; }
        public string ShortLink { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public Url()
        {

        }

        public Url(string link, string shortLink, Guid linkCode)
        {
            this.Link = link;
            this.ShortLink = shortLink;
            this.LinkCode = linkCode;
        }
    }
}
