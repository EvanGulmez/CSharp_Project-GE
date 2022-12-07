using Microsoft.AspNetCore.Mvc;

namespace Web_Appli_GE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {
        private static List<Hero> heroes = new List<Hero>
        {
            new Hero {Id=1, Name = "IronMan", FirstName="Tony", LastName ="Stark"},
            new Hero {Id=2, Name = "SpiderMan", FirstName="Yves", LastName ="Saint"},
            new Hero {Id=3, Name = "Hulk", FirstName="Roger", LastName ="Milla"},
            new Hero {Id=4, Name = "Thor", FirstName="Jean", LastName ="Hugues"},
            new Hero {Id=5, Name = "SanGoku", FirstName="Baptiste", LastName ="LeBon"}
        };

        public ActionResult<List<Hero>> Get() 
    }
}