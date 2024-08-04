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
		private readonly ObservableCollection<ItemViewModel> _viewInventoryCollection;

		public IEnumerable<ItemViewModel> InventoryItems => _viewInventoryCollection;

		public ICommand AddItemCommand { get; }
		public ICommand TestCommand { get; }
		public ICommand LoadItemsCommand { get; }

		public InventoryOverviewViewModel(Warehouse warehouse, NavigationService createNewItemNavigationService, NavigationService testCommandNavigationService)
		{
			_viewInventoryCollection = new ObservableCollection<ItemViewModel>();
			TestCommand = new NavigateCommand(testCommandNavigationService);
			LoadItemsCommand = new LoadItemsCommand(warehouse, this);
			AddItemCommand = new NavigateCommand(createNewItemNavigationService);
		}

		public static InventoryOverviewViewModel LoadViewModel(Warehouse warehouse, NavigationService createNewItemNavigationService, NavigationService testCommandNavigationService)
		{
			InventoryOverviewViewModel viewModel = new InventoryOverviewViewModel(warehouse, createNewItemNavigationService, testCommandNavigationService);

			viewModel.LoadItemsCommand.Execute(null);
			return viewModel;
		}

		public void UpdateInventory(IEnumerable<Item> items)
		{
			_viewInventoryCollection.Clear();
            foreach (Item item in items)
            {
                ItemViewModel inventoryOverviewViewModel = new ItemViewModel(item);
				_viewInventoryCollection.Add(inventoryOverviewViewModel);
            }
        }
	}
}
