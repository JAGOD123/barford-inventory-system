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
		public string Owner { get; }
		public string SingedOut { get; }
		public DateTime StartDate { get; }
		public DateTime EndDate { get; }
		public List<Item> Items { get; }

		public Order(int id, string owner, string singedOut, DateTime startDate, DateTime endDate, List<Item> items)
		{
			Id = id;
			Owner = owner;
			SingedOut = singedOut;
			StartDate = startDate;
			EndDate = endDate;
			Items = items;
		}

	}
}
