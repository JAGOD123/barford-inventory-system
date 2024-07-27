using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Barford_Inventory_System.ViewModels
{
	public class ItemViewModel : ViewModelBase
	{
		private InventoryItem _selectedItem;

		public ICommand addItemCommand { get; }
		public ItemViewModel(Inventory inventory)
		{
			addItemCommand = new AddItemCommand(inventory);
			LoadItems();
		}
		public ObservableCollection<InventoryItem> InventoryItems { get; set; }
	
		public void LoadItems()
		{
			ObservableCollection<InventoryItem> inventoryItems = new ObservableCollection<InventoryItem>();
			inventoryItems.Add(new InventoryItem { Name = "Name1", Description = "Desc1" });
			inventoryItems.Add(new InventoryItem { Name = "Name2", Description = "Desc2" });
			inventoryItems.Add(new InventoryItem { Name = "Name3", Description = "Desc3" });
			InventoryItems = inventoryItems;
		}

	}
}
