using Barford_Inventory_System.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Models
{
	public class Warehouse : ModelBase
	{
		/*
		 * I thinks this will eventually become an interface to the database more then anything
		 */
		public List<Order> Orders = new List<Order>();
		public List<Item> InStroage = new List<Item>();

		internal void AddOrder(Order order)
		{
			Orders.Add(order);
		}
	}
}
