using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke_Api.Dto
{
	public class PokemonDetails
	{
		public string Name { get; set; }
		public List<Habilidad> Abilities { get; set; }
		public Sprite Sprites { get; set; }
		public int base_experience { get; set; }
	}
}
