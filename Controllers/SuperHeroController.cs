using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SuperHeroAPI_DotNet7PatrickGYT.Controllers.Entities;

namespace SuperHeroAPI_DotNet7PatrickGYT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllHeroes()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name= "Test",
                    FirstName= "Test",
                    LastName= "Test",
                    Place= "Test"
                }
            };
            return Ok(heroes);
        }
    }
}
