using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Commands;
using ShortLinkGenerator.ApplicationContracts.Interfaces.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ShortLinkGenerator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlsController : ControllerBase
    {

        private readonly IUrlQueryService _urlQueryService;
        private readonly IUrlCommandService _urlCommandService;
        private readonly IUrlVisitorsCounterCommandService _urlVisitorsCounterCommandService;

        public UrlsController(
                               IUrlQueryService urlQueryService,
                               IUrlCommandService urlCommandService,
                               IUrlVisitorsCounterCommandService urlVisitorsCounterCommandService
                              )
        {
            _urlQueryService = urlQueryService;
            _urlCommandService = urlCommandService;
            _urlVisitorsCounterCommandService = urlVisitorsCounterCommandService;
        }

        [HttpGet("{id}", Name = "GetLink")]

        public async Task<IActionResult> GetLink([FromRoute] long id)
        {
            var link = await _urlQueryService.GetShortLink(id);

            if (string.IsNullOrEmpty(link))
                return NotFound();

            return Ok(link);
        }

        [HttpPost]
        public async Task<IActionResult> GenerateLink(string link)
        {
            try
            {
                var decodeUrl = WebUtility.UrlDecode(link);
                var entity = await _urlCommandService.GenerateLink(decodeUrl);


                return CreatedAtRoute("GetLink", new { id = entity.UrlId }, entity.ShortLink);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpGet("GetLinkByShortLink/{shortLink}")]
        public async Task<IActionResult> GetLinkByShortLink([FromRoute] string shortLink)
        {
            var decodeUrl = WebUtility.UrlDecode(shortLink);
            var entity =await _urlQueryService.GetLinkByShortLink(decodeUrl);

            if (string.IsNullOrEmpty(entity.Link))
                return NotFound();

          await  _urlVisitorsCounterCommandService.AddCount(entity.LinkCode);

            return Ok(entity.Link);
        }
    }
}
