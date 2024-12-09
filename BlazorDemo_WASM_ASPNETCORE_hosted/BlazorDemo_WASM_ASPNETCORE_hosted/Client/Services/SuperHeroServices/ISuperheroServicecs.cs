using BlazorDemo_WASM_ASPNETCORE_hosted.Shared;

namespace BlazorDemo_WASM_ASPNETCORE_hosted.Client.Services.SuperHeroServices
{
    public interface ISuperheroServicecs
    {
     List<SuperHero> Heros { get; set; }
     List<Comic> Comics { get; set; }

        public Task GetSuperHeros();
        public Task GetComics();
        public Task<SuperHero> GetSingleHero(int id);
    }
}
