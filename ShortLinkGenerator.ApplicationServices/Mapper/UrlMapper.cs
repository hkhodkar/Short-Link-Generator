using ShortLinkGenerator.ApplicationContracts.DTOs;
using ShortLinkGenerator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkGenerator.ApplicationServices.Mapper
{
    public static class UrLMapper
    {
        public static UrlDto Map(Url entity)
        {
            return new UrlDto()
            {
                UrlId = entity.UrlId,
                Link = entity.Link,
                LinkCode = entity.LinkCode,
                ShortLink = entity.ShortLink
            };
        }
    } 
}
