using Barford_Inventory_System.Models;
using Barford_Inventory_System.Stores;
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
		private readonly WarehouseStore _warehouseStore;
		private readonly InventoryOverviewViewModel _viewModel;

		public LoadItemsCommand(WarehouseStore warehouseStore, InventoryOverviewViewModel viewModel)
		{
			_warehouseStore = warehouseStore;
			_viewModel = viewModel;
		}

		public override async Task ExecuteAsync(object parammeter)
		{
			await _warehouseStore.Load();
			_viewModel.UpdateInventory(_warehouseStore.Items);
		}
	}
}
