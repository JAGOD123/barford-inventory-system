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
		public List<Order> Orders = new List<Order>();
		public List<Item> InStroage = new List<Item>();
	}
}
