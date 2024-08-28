using Barford_Inventory_System.Models;
using Barford_Inventory_System.ViewModels;
using Barford_Inventory_System.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Barford_Inventory_System.Commands
{
	public class LoadOrdersCommand : CommandBase
	{
		private readonly OrdersOverviewViewModel _viewModel;
		private readonly Warehouse _warehouse;

		public LoadOrdersCommand(OrdersOverviewViewModel viewModel, Warehouse warehouse)
		{
			_warehouse = warehouse;
			_viewModel = viewModel;
		}
		public override void Execute(object? parameter)
		{
			try
			{
				IEnumerable<Order> orders = _warehouse.GetAllOrders();
				_viewModel.UpdateOrders(orders);
			} catch (Exception ex)
			{
				MessageBox.Show("Failed to load Orders.", "Error",
				   MessageBoxButton.OK, MessageBoxImage.Error);

			}
		}
	}
}
