using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
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
    class MakeNewItemCommand : CommandBase
    {
		private readonly CreateNewItemViewModel _createNewItemViewModel;
		private readonly Warehouse _warehouse;
		private readonly NavigationService _inventoryOverviewNavigationService;

		public MakeNewItemCommand(CreateNewItemViewModel createNewItemViewModel,
			Warehouse warehouse,
			NavigationService inventoryOverviewNavigationService)
		{
			_createNewItemViewModel = createNewItemViewModel;
			_warehouse = warehouse;
			_inventoryOverviewNavigationService = inventoryOverviewNavigationService;
			_createNewItemViewModel.PropertyChanged += OnViewModelPropertyChanged;
		}


		public override bool CanExecute(object? parameter)
		{
			return !string.IsNullOrEmpty(_createNewItemViewModel.Name) && base.CanExecute(parameter);
		}


		public override void Execute(object? parameter)
		{
			Item item = new Item(
				_createNewItemViewModel.Name,
				_createNewItemViewModel.Description
				);
			_warehouse.MakeItem(item);
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
