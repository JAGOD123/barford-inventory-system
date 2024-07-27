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
	public class ItemViewModel
	{
		private InventoryItem _selectedItem;


		public MyICommand DeleteCommand { get; set; }

		public ItemViewModel()
		{
			LoadItems();
			DeleteCommand = new MyICommand(OnDelete, CanDelete);
		}
		public ObservableCollection<InventoryItem> InventoryItems { get; set; }
		public InventoryItem SelectedItem
		{
			get { return _selectedItem; }

			set
			{
				_selectedItem = value;
				DeleteCommand.RaiseCanExecuteChanged();
			}
		}




		public void LoadItems()
		{
			ObservableCollection<InventoryItem> inventoryItems = new ObservableCollection<InventoryItem>();
			inventoryItems.Add(new InventoryItem { Name = "Name1", Description = "Desc1" });
			inventoryItems.Add(new InventoryItem { Name = "Name2", Description = "Desc2" });
			inventoryItems.Add(new InventoryItem { Name = "Name3", Description = "Desc3" });
			InventoryItems = inventoryItems;
		}



		private void OnDelete()
		{

			InventoryItems.Remove(SelectedItem);

		}

		private bool CanDelete()
		{
			return SelectedItem != null;
		}
	}
}
