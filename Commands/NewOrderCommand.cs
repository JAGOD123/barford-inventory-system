using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using Barford_Inventory_System.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Barford_Inventory_System.Commands
{
	public class NewOrderCommand : CommandBase
	{
		private readonly NewOrderViewModel _newOrderViewModel;
		private readonly NavigationService _orderOverviewNavService;
		private readonly Warehouse _warehouse;

		public NewOrderCommand(Warehouse warehouse, NewOrderViewModel newOrderViewModel,
			NavigationService newOrderNavService)
		{
			_warehouse = warehouse;
			_newOrderViewModel = newOrderViewModel;
			_orderOverviewNavService = newOrderNavService;

			_newOrderViewModel.PropertyChanged += OnViewModelPropertyChanged;
		}

		public override bool CanExecute(object? parameter)
		{
			return !string.IsNullOrEmpty(_newOrderViewModel.Owner) &&
				   !string.IsNullOrEmpty(_newOrderViewModel.SingedOut) &&
					base.CanExecute(parameter);
		}  
		public override void Execute(object? parameter)
		{
			/*
			 * TODO: Add in exceptions to check for validation of the orders
			 */
			Order order = new Order(
				_newOrderViewModel.Id,
				_newOrderViewModel.Owner,
				_newOrderViewModel.SingedOut,
				_newOrderViewModel.StartDate,
				_newOrderViewModel.EndDate,
				_newOrderViewModel.Items
				);
			MessageBox.Show("Successfull added Order", "Success",
				MessageBoxButton.OK, MessageBoxImage.Information);
			_warehouse.AddOrder(order);
			_orderOverviewNavService.Navigate();
		}

		private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == nameof(NewOrderViewModel.Owner) ||
				e.PropertyName == nameof(NewOrderViewModel.SingedOut))
			{
				OnCanExecuteChanged();
			}
		}
	}
}