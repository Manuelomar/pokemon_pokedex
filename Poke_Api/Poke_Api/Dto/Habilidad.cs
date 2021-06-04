using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke_Api.Dto
{
	public class Habilidad
	{
		public Detalles_habilidad habilidad { get; set; }
		public bool is_hidden { get; set; }
		public int Slot { get; set; }
	}
}
