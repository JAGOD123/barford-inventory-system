using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Barford_Inventory_System.ViewModels
{
	public class ItemViewModel : ViewModelBase
	{
		private InventoryItem? _selectedItem;
		public ObservableCollection<InventoryItem> InventoryItems;

		public ICommand addItemCommand { get; }

		//public ItemViewModel()
		//{
		//	MessageBox.Show("Here1");
		//}
		public ItemViewModel(Inventory inventory)
		{
			addItemCommand = new AddItemCommand(inventory);
			InventoryItems = new ObservableCollection<InventoryItem>(inventory.InventoryItems);
			MessageBox.Show(InventoryItems[0].Name);
		}
	}
}
