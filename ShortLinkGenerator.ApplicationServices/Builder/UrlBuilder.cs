using ShortLinkGenerator.ApplicationContracts.DTOs;
using ShortLinkGenerator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkGenerator.ApplicationServices.Builder
{
    public static class UrlBuilder
    {
        public static Url Build(UrlDto dto)
        {
            return new Url(dto.Link, dto.ShortLink, dto.LinkCode);
        }

        public static UrlVisitorsCounter Build(UrlVisitorsCounterDto dto)
        {
            return new UrlVisitorsCounter(dto.LinkCode);
        }

    }
}
