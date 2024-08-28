using Barford_Inventory_System.DbContexts;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using Barford_Inventory_System.Stores;
using Barford_Inventory_System.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
		private readonly Warehouse _warehouse = new Warehouse();
		private readonly BISDbContextFactory _bisDbContextFactory;
		private NavigationStore _navStore;
		public App()
		{
			_navStore = new NavigationStore();
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			/*
			using (BISDbContext dbContext = _bisDbContextFactory.CreateDbContext())
			{
				dbContext.Database.Migrate();

			}
			*/

			_navStore.CurrentViewModel = C_OrdersOverviewViewModel();
			MainWindow = new MainWindow()
			{
				DataContext = new MainWindowViewModel(_navStore)
			};
			MainWindow.Show();
			base.OnStartup(e);
		}

		private OrdersOverviewViewModel C_OrdersOverviewViewModel()
		{
			return new OrdersOverviewViewModel(_warehouse, new NavigationService(_navStore, C_NewOrderViewModel));
		}

		private NewOrderViewModel C_NewOrderViewModel()
		{
			return new NewOrderViewModel(_warehouse, new NavigationService(_navStore, C_OrdersOverviewViewModel));
		}
	}
}
