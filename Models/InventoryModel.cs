using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Barford_Inventory_System.Models
{
    public class Inventory : ModelBase
    {
		private string _ID;
		private List<InventoryItem> _inventory;


		public string ID
		{
			get
			{
				return _ID;
			}
			set
			{
				if (_ID != value)
				{
					_ID = value;
					RaisePropertyChanged("ID");
				}
			}
		}
		public List<InventoryItem> Items
		{
			get
			{
				return _inventory;
			}
			set
			{
				if (_inventory != value)
				{
					_inventory = value;
					RaisePropertyChanged("Inventory");
				}
			}
		}


		public Inventory(string id)
		{
			_ID = id;
		}



		public void AddItem(InventoryItem item)
		{
			_inventory.Append(item);
		}
	}
}
