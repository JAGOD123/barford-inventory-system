using Barford_Inventory_System.DbContexts;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using Barford_Inventory_System.Services.InventoryProviders;
using Barford_Inventory_System.Services.ItemConflictValidators;
using Barford_Inventory_System.Services.ItemCreators;
using Barford_Inventory_System.Stores;
using Barford_Inventory_System.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Barford_Inventory_System
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private const string CONNECTION_STRING = "Data Source=BIS.db";
		private readonly Warehouse _warehouse;
		private readonly WarehouseStore _warehouseStore;
		private readonly NavigationStore _navigationStore;
		private readonly BISDbContextFactory _bisDbContextFactory;

		public App()
		{
			_bisDbContextFactory = new BISDbContextFactory(CONNECTION_STRING);
			IItemProvider itemProvider = new DatabaseItemProvider(_bisDbContextFactory);
			IItemCreator itemCreator = new DatabaseItemCreator(_bisDbContextFactory);
			IItemConflictValidator itemConflictValidator = new DatabaseItemConflictValidator(_bisDbContextFactory);



			Storage storage = new Storage(itemProvider, itemCreator, itemConflictValidator);
			_warehouse = new Warehouse("001", storage);
			_warehouseStore = new WarehouseStore(_warehouse);
			_navigationStore = new NavigationStore();
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			using (BISDbContext dbContext = _bisDbContextFactory.CreateDbContext())
			{
				dbContext.Database.Migrate();

			}


			_navigationStore.CurrentViewModel = CreateInventoryOverviewViewModel();

			MainWindow = new MainWindow()
			{
				DataContext = new MainWindowViewModel(_navigationStore)
			};
			MainWindow.Show();
			base.OnStartup(e);
		}


		private CreateNewItemViewModel CreateMakeNewItemViewModel()
		{
			return new CreateNewItemViewModel(_warehouseStore, new NavigationService(_navigationStore, CreateInventoryOverviewViewModel));
		}

		private InventoryOverviewViewModel CreateInventoryOverviewViewModel()
		{
			return InventoryOverviewViewModel.LoadViewModel(
				_warehouseStore, 
				new NavigationService(_navigationStore, CreateMakeNewItemViewModel),
				new NavigationService(_navigationStore, CreateTestViewModel));
		}

		private TestViewModel CreateTestViewModel()
		{
			return new TestViewModel(new NavigationService(_navigationStore, CreateInventoryOverviewViewModel));
		}
	}

}
