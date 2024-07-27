using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Barford_Inventory_System.Models
{
    public class Inventory : ModelBase
    {
		private string _ID;
		private List<Item> _inventory;

		public Inventory(string id)
		{
			_ID = id;
			_inventory = new List<Item>();
		}

		public void LoadItems()
		{
			_inventory.Add(new Item("Name1", "Desc1"));
			_inventory.Add(new Item("Name2", "Desc2"));
			_inventory.Add(new Item("Name3", "Desc3"));
		}

		public void AddItem(Item item)
		{
			_inventory.Append(item);
		}
	}
}
