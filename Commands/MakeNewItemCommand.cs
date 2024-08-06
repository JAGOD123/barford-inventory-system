using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using Barford_Inventory_System.Stores;
using Barford_Inventory_System.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Barford_Inventory_System.Commands
{
    class MakeNewItemCommand : AsyncCommandBase
    {
		private readonly CreateNewItemViewModel _createNewItemViewModel;
		private readonly WarehouseStore _warehouseStore;
		private readonly NavigationService _inventoryOverviewNavigationService;

		public MakeNewItemCommand(CreateNewItemViewModel createNewItemViewModel,
			WarehouseStore warehouseStore,
			NavigationService inventoryOverviewNavigationService)
		{
			_createNewItemViewModel = createNewItemViewModel;
			_warehouseStore = warehouseStore;
			_inventoryOverviewNavigationService = inventoryOverviewNavigationService;
			_createNewItemViewModel.PropertyChanged += OnViewModelPropertyChanged;
		}


		public override bool CanExecute(object? parameter)
		{
			return !string.IsNullOrEmpty(_createNewItemViewModel.Name) && base.CanExecute(parameter);
		}


		public override async Task ExecuteAsync(object? parameter)
		{
			Item item = new Item(
				_createNewItemViewModel.Name,
				_createNewItemViewModel.Description
				);
			_warehouseStore.MakeItem(item);
			_inventoryOverviewNavigationService.Navigate();
		}
		private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(CreateNewItemViewModel.Name))
			{
				OnCanExecuteChanged();
			}
		}
	}
}
