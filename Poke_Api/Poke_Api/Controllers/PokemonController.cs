using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Poke_Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Poke_Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PokemonController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> Obtener_Pokemones()
		{
			var HTTP = new HttpClient();
			var respuesta = await HTTP.GetAsync("https://pokeapi.co/api/v2/pokemon/?offset=100&limit=100");
			var pokemons = respuesta.Content.ReadAsStringAsync();
			Pokemon listadePokemones = JsonConvert.DeserializeObject<Pokemon>(pokemons.Result);
			return Ok(listadePokemones);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> Obtener_Pokemon_Especifico([FromRoute]string id)
		{
			var HTTP = new HttpClient();
			var respuesta = await HTTP.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}/");
			var pokemons = respuesta.Content.ReadAsStringAsync();
			PokemonDetails pokemonEspecifico = JsonConvert.DeserializeObject<PokemonDetails>(pokemons.Result);
			return Ok(pokemonEspecifico);
		}
	}
}
