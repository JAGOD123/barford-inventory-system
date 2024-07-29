using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using Barford_Inventory_System.Stores;
using Barford_Inventory_System.ViewModels;
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
		private readonly Storage _inventory;
		private readonly NavigationStore _navigationStore;

		public App()
		{
			_inventory = new Storage("001");
			_navigationStore = new NavigationStore();
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			_navigationStore.CurrentViewModel = CreateInventoryOverviewViewModel();

			MainWindow = new MainWindow()
			{
				DataContext = new MainWindowViewModel(_navigationStore)
			};
			MainWindow.Show();
			base.OnStartup(e);
		}


		private CreateNewItemViewModel CreateCreateNewItemViewModel()
		{
			return new CreateNewItemViewModel(_inventory, new NavigationService(_navigationStore, CreateInventoryOverviewViewModel));
		}

		private InventoryOverviewViewModel CreateInventoryOverviewViewModel()
		{
			return new InventoryOverviewViewModel(_inventory, new NavigationService(_navigationStore, CreateCreateNewItemViewModel));
		}
	}

}
