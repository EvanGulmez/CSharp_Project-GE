using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

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

        private readonly ApplicationDbContext _context;

        public HeroController(ApplicationDbContext dbContext) 
        {
            this._context = dbContext;        
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Hero>>> Get()
        {
            var myHeroes = await _context.Heroes.ToListAsync();
            return Ok(heroes);
        }

        [HttpPost]
        public async Task<ActionResult<List<Hero>>> CreateHero(int name, [FromBody]Hero hero) 
        {
            heroes.Add(hero);
            return Ok(heroes);
        }

        [HttpPut("{id}")]
            public async Task<ActionResult<List<Hero>>> UpdateHero(int id, string name, String firstname, string lastname)
            {
                // Use a try-catch block to handle the case where the hero is not found
                try
                {
                    // Find the hero by its id
                    var heroToUpdate = heroes.First(h => h.Id == id);

                // Update the hero's properties
                    heroToUpdate.Name = name;
                    heroToUpdate.FirstName = firstname ;
                    heroToUpdate.LastName = lastname ;

                    return Ok(heroes);
                }
                catch (InvalidOperationException)
                {
                    // Return a NotFound result if the hero is not found
                    return NotFound();
                }
            }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Hero>>> DeleteHero(int id)
        {
            var heroToDelete = heroes.FirstOrDefault(h => h.Id == id);
            if (heroToDelete != null)
            {
                heroes.Remove(heroToDelete);
                return Ok(heroes);
            }
            else
            {
                return NotFound();
            }
        }
    }
}