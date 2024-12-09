using BlazorDemo_WASM_ASPNETCORE_hosted.Shared;
using System.Net.Http.Json;
namespace BlazorDemo_WASM_ASPNETCORE_hosted.Client.Services.SuperHeroServices
{
    public class SuperheroService:ISuperheroServicecs
    {
        public HttpClient _http { get; }
        public SuperheroService(HttpClient http)
        {
            this._http = http;
        }

      
       public   List<SuperHero> Heros { get; set; } = new List<SuperHero> { };
        
       public  List<Comic> Comics { get; set; } = new List<Comic> { };
     

        public  Task GetComics()
        {
            throw new NotImplementedException();
        }

        public  async Task GetSuperHeros()
        {
            var result = await this._http.GetFromJsonAsync<List<SuperHero>>("api/Superhero");
            if(result!=null)
            {
                Heros = result;
            }
            

        }

        public Task<SuperHero> GetSingleHero(int id)
        {
            var result = _http.GetFromJsonAsync<SuperHero>($"api/Superhero/{id}");
            if(result!=null)
//#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
                return result;
//#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
             throw new Exception("Hero not found");
        }
    }
}
