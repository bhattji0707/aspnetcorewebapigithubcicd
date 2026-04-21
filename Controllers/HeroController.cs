using aspnetcorewebapi.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspnetcorewebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        // GET: api/<HeroController>
        [HttpGet]
        public ActionResult<IList<HeroDTO>> Heros()
        {
            //var heroList = new Dictionary<int, string> {
            //        { 12, "Dr. Nice" },
            //        { 13, "Bombasto" },
            //        { 14, "Celeritas" },
            //        { 15, "Magneta" },
            //        { 16, "RubberMan" },
            //        { 17, "Dynama" },
            //        { 18, "Dr. IQ" },
            //        { 19, "Magma" },
            //        { 20, "Tornado" }
            //    };
            IList<HeroDTO> heroList = new List<HeroDTO> {
                        new HeroDTO { id=  12, name= "Dr. Virendar" ,isActive=true},
            new HeroDTO { id=   13,  name= "Bombasto" ,isActive=true},
            new HeroDTO { id=   14,  name= "Celeritas" ,isActive=true},
            new HeroDTO { id=   15,  name= "Magneta" ,isActive=false},
            new HeroDTO { id=   16,  name= "RubberMan" ,isActive=true},
            new HeroDTO { id=   17,  name= "Dynama" ,isActive=false},
            new HeroDTO { id=   18,  name= "Dr. IQ" ,isActive=true},
            new HeroDTO { id=   19,  name= "Magma" ,isActive=false},
            new HeroDTO { id=   20,  name= "Tornado" ,isActive=true}
                    };
            Thread.Sleep(5000);
            return Ok(heroList);


        }

        // GET api/<HeroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HeroController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HeroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HeroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet("active")]
        public ActionResult<IList<HeroDTO>> GetActiveHero([FromQuery] bool? active)
        {
            IList<HeroDTO> heroList = new List<HeroDTO> {
                        new HeroDTO { id=  12, name= "Dr. Virendar" ,isActive=true},
            new HeroDTO { id=   13,  name= "Bombasto" ,isActive=true},
            new HeroDTO { id=   14,  name= "Celeritas" ,isActive=true},
            new HeroDTO { id=   15,  name= "Magneta" ,isActive=false},
            new HeroDTO { id=   16,  name= "RubberMan" ,isActive=true},
            new HeroDTO { id=   17,  name= "Dynama" ,isActive=false},
            new HeroDTO { id=   18,  name= "Dr. IQ" ,isActive=true},
            new HeroDTO { id=   19,  name= "Magma" ,isActive=false},
            new HeroDTO { id=   20,  name= "Tornado" ,isActive=true}
                    };
            Thread.Sleep(5000);
            return Ok(heroList.Where(x=>x.isActive));
        }
    }
}
