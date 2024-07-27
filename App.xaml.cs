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
		protected override void OnStartup(StartupEventArgs e)
		{
			MainWindow = new MainWindow()
			{
				DataContext = new MainWindowViewModel()
			};
			MainWindow.Show();
			base.OnStartup(e);
		}
		
	}

}
