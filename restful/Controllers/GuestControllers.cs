using CreateApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restful.Entities;
using restful.core.Services;

namespace RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : Controller
    {

        private readonly IGuestService guestService;
        public GuestController(IGuestService guestService_)
        {
            guestService = guestService_;
        }
        //private DataContext _dataContext;

        //public GuestController(DataContext DC)
        //{
        //    _dataContext = DC;
        //}
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Guest> Get() => guestService.GetGuests();


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Guest> Get(int id)
        {
            var x = guestService.GetGuests().Find(x => x.Id == id);
            if (x == null)
            {
                return NotFound();
            }

            return x;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Guest value)
        {
            guestService.GetGuests().Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult<Guest> Put(int id, [FromBody] Guest value)
        {
            var x = guestService.GetGuests().Find(e => e.Id == id);
            x.Status = value.Status;
            if (x == null)
            {
                return NotFound();
            }

            return x;
        }
        [HttpPut("{id}/status")]
        public Guest Put(int id, [FromBody] string status)
        {
            //find the object by id
            var x = guestService.GetGuests().Find(e => e.Id == id);
            //udpate properties
            //eve.Title = updateEvent.Title;
            return x;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var x = guestService.GetGuests().Find(e => e.Id == id);
            if (x == null)
            {
                NotFound();
            }
            else guestService.GetGuests().Remove(x);
        }
    }
}
