using Barford_Inventory_System.DbContexts;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using Barford_Inventory_System.Services.InventoryProviders;
using Barford_Inventory_System.Services.ItemConflictValidators;
using Barford_Inventory_System.Services.ItemCreators;
using Barford_Inventory_System.Services.OrderCreators;
using Barford_Inventory_System.Services.OrderProviders;
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
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			/*
			using (BISDbContext dbContext = _bisDbContextFactory.CreateDbContext())
			{
				dbContext.Database.Migrate();

			}
			*/

			//_navigationStore.CurrentViewModel = CreateInventoryOverviewViewModel();

			MainWindow = new MainWindow()
			{
				DataContext = new MainWindowViewModel(_navigationStore)
			};
			MainWindow.Show();
			base.OnStartup(e);
		}


	}
}
