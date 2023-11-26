using CreateApi;
using Microsoft.AspNetCore.Mvc;
using restful.core.Services;
using restful.Entities;

namespace RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        private readonly IRoomService RoomService;
     
        public RoomController(IRoomService RoomService_)
        {
            RoomService = RoomService_;
        }
        //private DataContext _dataContext;

        //public RoomController(DataContext DC)
        //{
        //    _dataContext = DC;
        //}

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Room> Get() => RoomService.GetRooms();


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Room> Get(int id)
        {
            var x = RoomService.GetRooms().Find(x => x.Id == id);
            if (x == null)
            {
                return NotFound();
            }

            return x;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Room value)
        {
            RoomService.GetRooms().Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult<Room> Put(int id, [FromBody] Room value)
        {
            var x = RoomService.GetRooms().Find(e => e.Id == id);
            if (x == null)
            {
                return NotFound();
            }
            x.Avialable = value.Avialable;
            x.Id = id;

            return x;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var x = RoomService.GetRooms().Find(e => e.Id == id);
            if (x == null)
            {
                NotFound();
            }
            RoomService.GetRooms().Remove(x);
        }
    }
}
