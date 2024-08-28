using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Models
{
	public class Order : ModelBase
	{
		public int Id { get; }
		public String Owner { get; }
		public String SingedOut { get; }
		public DateTime StartDate { get; }
		public DateTime EndDate { get; }

		public List<Item> Items { get; }


	}
}
