using Barford_Inventory_System.Models;
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
		private readonly Inventory _inventory;

		public App()
		{
			_inventory = new Inventory("001");
			_inventory.LoadItems();
		}

		
		protected override void OnStartup(StartupEventArgs e)
		{
			MainWindow = new MainWindow()
			{
				DataContext = new ItemViewModel(_inventory)
			};
			MainWindow.Show();
			base.OnStartup(e);
		}
		
	}

}
