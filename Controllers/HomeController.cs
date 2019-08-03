using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeachApi.Models;

namespace TchSite.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly ApiContext _ctx;
        public HomeController(ApiContext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var cards = _ctx.Cards.Where(c => c.HostCardId == null);
            return Ok(cards);
        }

        //[HttpGet("[action]")]
    }
}
