using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Barford_Inventory_System.ViewModels
{
	public class OrdersOverviewViewModel : ViewModelBase
	{
		private readonly ObservableCollection<SingleOrderViewModel> _orders;
		private readonly Warehouse _warehouse;

		public IEnumerable<SingleOrderViewModel> ViewOrders => _orders;

		public ICommand MakeOrderCommand { get; }
		public ICommand LoadOrdersCommand { get; }

		public OrdersOverviewViewModel(Warehouse warehouse, NavigationService newOrderNavService)
		{
			_orders = new ObservableCollection<SingleOrderViewModel>();
			_warehouse = warehouse;
			LoadOrdersCommand = new LoadOrdersCommand(this, warehouse);
			MakeOrderCommand = new NavigateCommand(newOrderNavService);

			warehouse.OrdersChanged += OnOrdersChanged;
			UpdateOrders(_warehouse.GetAllOrders());
		}

		public static OrdersOverviewViewModel LoadViewModel(Warehouse warehouse, NavigationService newOrderNavService)
		{
			OrdersOverviewViewModel viewModel = new OrdersOverviewViewModel(warehouse, newOrderNavService);
			viewModel.LoadOrdersCommand.Execute(null);
			return viewModel;
		}

		public void UpdateOrders(IEnumerable<Order> orders)
		{
			_orders.Clear();
			foreach (Order order in orders)
			{
				SingleOrderViewModel viewModel = new SingleOrderViewModel(order);
				_orders.Add(viewModel);
			}
		}
		private void OnOrdersChanged()
		{
			LoadOrdersCommand.Execute(null); // Reload orders when warehouse changes
		}

	}
}

