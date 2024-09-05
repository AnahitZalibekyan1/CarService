using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34.Models
{
	class CarType(int id, string carName, float coificent)
	{
		public int Id => id;
		public string CarName => carName;
		public float Coificent => coificent;


		public CarType() : this(1, "", 4.1f)
		{

		}
	}
}
