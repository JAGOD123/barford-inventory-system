using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Barford_Inventory_System
{
	public class InventoryItem
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Condition { get; set; }
		
		public InventoryItem() { }
	}
}
