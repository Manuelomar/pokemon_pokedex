using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke_Api.Dto
{
	public class Pokemon
	{
		public int Count { get; set; }
		public string Next { get; set; }
		public string Previous { get; set; }
		public List<Resultado> Results { get; set; }
	}
}
