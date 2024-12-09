using BlazorDemo_WASM_ASPNETCORE_hosted.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo_WASM_ASPNETCORE_hosted.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public static List<Comic> comics = new List<Comic>()
        {new Comic{Id=1,Name="Marvel"},
            new Comic {Id=2,Name="DC"}

        };

        public static List<SuperHero> Heros = new List<SuperHero>()
        {
            new SuperHero{Id=1,FirstName="Peter",LastName="God",HeroName="Don",Comic=comics[0]},
             new SuperHero{Id=2,FirstName="Ameet",LastName="Lad",HeroName="BahuBali",Comic=comics[1]},

        };

        [HttpGet]
        public ActionResult<List<SuperHero>> GetSuperHeros()
        {
            return Ok(Heros);
        }

        [HttpGet("{id}")]
        public  ActionResult<SuperHero> GetSingleHero(int id)
        {var hero= Heros.FirstOrDefault(h => h.Id == id);
            if(hero==null)
            {
                return NotFound("Sorry Hero not found");
            }
            else
                return Ok(hero);
         
        }




    }
}
