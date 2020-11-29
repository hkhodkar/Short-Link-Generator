using ShortLinkGenerator.ApplicationContracts.DTOs;
using ShortLinkGenerator.Core.Entities;

namespace ShortLinkGenerator.ApplicationServices.Mapper
{
    public static class UrlVisitorsCounterMapper
    {
        public static UrlVisitorsCounterDto Map(UrlVisitorsCounter entity)
        {
            return new UrlVisitorsCounterDto()
            {
                Count = entity.Count,
                LinkCode = entity .LinkCode
            };
        }
    }
}
