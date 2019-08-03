using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeachApi.Models;

namespace TchSite.Controllers
{
    [Route("api/feed")]
    public class FeedController : Controller
    {
        private readonly ApiContext _ctx;
        public FeedController(ApiContext ctx)
        {
            _ctx = ctx;
            if(!_ctx.Events.Any())
            {
                List<Photo> photos = new List<Photo>();
                photos.Add(new Photo {Name = "photo1",Image = "feedtest1.jpg"});
                photos.Add(new Photo {Name = "photo2",Image = "feedtest2.jpg"});
                photos.Add(new Photo {Name = "photo3",Image = "feedtest3.jpg"});
                photos.Add(new Photo {Name = "photo4",Image = "feedtest4.jpg"});
                _ctx.Events.Add(new Event { Name = "Собрание", Photos = photos });
                _ctx.Events.Add(new Event { Name = "Митинг", Photos = photos });
                _ctx.Events.Add(new Event { Name = "Демонстрация", Photos = photos });
                _ctx.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _ctx.Events;
        }
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _ctx.Events.FirstOrDefault(e => e.ID == id);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Event evnt)
        {
            if (ModelState.IsValid)
            {
                _ctx.Update(evnt);
                _ctx.SaveChanges();
                return Ok(evnt);
            }
            return BadRequest(ModelState);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Event evnt = _ctx.Events.FirstOrDefault(x => x.ID == id);
            if(evnt!=null)
            {
                _ctx.Events.Remove(evnt);
                _ctx.SaveChanges();
            }
            return Ok(evnt);
        }
    }
}