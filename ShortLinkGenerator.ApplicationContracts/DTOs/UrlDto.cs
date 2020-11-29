using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkGenerator.ApplicationContracts.DTOs
{
    public class UrlDto
    {
        public long UrlId { get; set; }
        public string Link { get; set; }
        public string LinkCode { get; set; }
        public string ShortLink { get; set; }
    }
}
