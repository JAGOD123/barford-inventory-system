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

		public CreateNewItemViewModel CreateNewItemViewModel { get; }

		private WarehouseStore _warehouseStore { get; }

		public ICommand AddItemCommand { get; }
		public ICommand TestCommand { get; }
		public ICommand LoadItemsCommand { get; }

		public InventoryOverviewViewModel(
			WarehouseStore warehouseStore,
			NavigationService createNewItemNavigationService,
			NavigationService testCommandNavigationService,
			CreateNewItemViewModel createNewItemViewModel)
		{
			_warehouseStore = warehouseStore;
			_viewInventoryCollection = new ObservableCollection<ItemViewModel>();

			TestCommand = new NavigateCommand(testCommandNavigationService);
			LoadItemsCommand = new LoadItemsCommand(_warehouseStore, this);
			AddItemCommand = new NavigateCommand(createNewItemNavigationService);

			CreateNewItemViewModel = createNewItemViewModel;

			_warehouseStore.ItemMade += OnItemMade;
		}

		public override void Dispose()
		{
			_warehouseStore.ItemMade -= OnItemMade;
			base.Dispose();
		}


		private void OnItemMade(Item item)
		{
			ItemViewModel itemViewModel = new ItemViewModel(item);
			_viewInventoryCollection.Add(itemViewModel);
		}

		public static InventoryOverviewViewModel LoadViewModel(
			WarehouseStore warehouseStore,
			CreateNewItemViewModel createNewItemViewModel,
			NavigationService createNewItemNavigationService,
			NavigationService testCommandNavigationService)
		{
			InventoryOverviewViewModel viewModel = new InventoryOverviewViewModel(
				warehouseStore,
				createNewItemNavigationService,
				testCommandNavigationService,
				createNewItemViewModel);

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
