using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using Barford_Inventory_System.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
		private readonly Storage _store;
		private readonly ObservableCollection<ItemViewModel> _viewInventoryCollection;

		public IEnumerable<ItemViewModel> InventoryItems => _viewInventoryCollection;

		public ICommand AddItemCommand { get; }

		public InventoryOverviewViewModel(Storage inventory, NavigationService createNewItemNavigationService)
		{
			_store = inventory;
			_viewInventoryCollection = new ObservableCollection<ItemViewModel>();

			AddItemCommand = new NavigateCommand(createNewItemNavigationService);

			UpdateInventory();
		}

		private void UpdateInventory()
		{
			_viewInventoryCollection.Clear();
            foreach (var item in _store.GetItems())
            {
                ItemViewModel inventoryOverviewViewModel = new ItemViewModel(item);
				_viewInventoryCollection.Add(inventoryOverviewViewModel);
            }
        }
	}
}
