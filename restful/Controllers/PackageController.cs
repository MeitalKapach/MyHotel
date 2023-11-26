using CreateApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restful.core.Services;
using restful.Entities;
namespace restful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : Controller
    {
        private readonly IPackageService packageService;
   
        public PackageController(IPackageService packageService_)
        {
            packageService = packageService_;
        }
        //private DataContext _dataContext;

        //public PackageController(DataContext DC)
        //{
        //    _dataContext = DC;
        //}

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Package> Get() => packageService.GetPackages();


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Package> Get(int id)
        {
            var x = packageService.GetPackages().Find(x => x.Id == id);
            if (x == null)
            {
                return NotFound();
            }

            return x;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Package value)
        {
            packageService.GetPackages().Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult<Package> Put(int id, [FromBody] Package value)
        {
            var x = packageService.GetPackages().Find(e => e.Id == id);
            if (x == null)
            {
                return NotFound();
            }
            x.Price = value.Price;
            return x;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var x = packageService.GetPackages().Find(e => e.Id == id);
            if (x == null)
            {
                NotFound();
            }
            packageService.GetPackages().Remove(x);
        }
    }
}
