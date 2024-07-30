using Barford_Inventory_System.Models;
using Barford_Inventory_System.ViewModels;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Commands
{
	public class LoadItemsCommand : AsyncCommandBase
	{
		private readonly Warehouse _warehouse;
		private readonly InventoryOverviewViewModel _viewModel;

		public LoadItemsCommand(Warehouse warehouse, InventoryOverviewViewModel viewModel)
		{
			_warehouse = warehouse;
			_viewModel = viewModel;
		}

		public override async Task ExecuteAsync(object parammeter)
		{
			IEnumerable<Item> items = await _warehouse.GetAllItems();
			_viewModel.UpdateInventory(items);
		}
	}
}
