using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortLinkGenerator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlVisitorsCountersController : ControllerBase
    {
        private readonly IUrlQueryService _urlQueryService;
        private readonly IUrlVisitorsCounterQueryService _urlVisitorsCounterQueryService;

        public UrlVisitorsCountersController(IUrlVisitorsCounterQueryService urlVisitorsCounterQueryService, IUrlQueryService urlQueryService)
        {
            _urlQueryService = urlQueryService;
            _urlVisitorsCounterQueryService = urlVisitorsCounterQueryService;
        }


        [HttpGet]
        public async Task<IActionResult> GetVisitorsCount(string link)
        {
            var dto =await _urlQueryService.GetLink(link);

            if (dto == null)
                return NotFound();

            var count = await _urlVisitorsCounterQueryService.GetUrlVisitorsCount(dto.LinkCode);

            return Ok(count);
        }
    }
}
