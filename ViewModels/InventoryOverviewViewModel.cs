using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Barford_Inventory_System.ViewModels
{
	public class InventoryOverviewViewModel : ViewModelBase
	{
		private readonly ObservableCollection<ItemViewModel> _inventory;

		public IEnumerable<ItemViewModel> InventoryItems => _inventory;


		public InventoryOverviewViewModel(Inventory inventory)
		{
			_inventory = new ObservableCollection<ItemViewModel>();

			_inventory.Add(new ItemViewModel(new Item("Name11", "Desc11")));
			_inventory.Add(new ItemViewModel(new Item("Name12", "Desc12")));
			_inventory.Add(new ItemViewModel(new Item("Name13", "Desc13")));

		}

		/*
		private Item? _selectedItem;
		public ObservableCollection<Item> InventoryItems;


		public InventoryOverviewViewModel(Inventory inventory)
		{
		addItemCommand = new AddItemCommand(inventory);
		InventoryItems = new ObservableCollection<Item>(inventory.InventoryItems);
		MessageBox.Show(InventoryItems[0].Name);
		}
		


		
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
		public List<Item> InventoryItems
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
		*/



	}
}
