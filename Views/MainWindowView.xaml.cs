using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.ViewModels;

namespace Barford_Inventory_System
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		/*
		private void ItemViewControl_Loaded(object sender, RoutedEventArgs e)
		{
			InventoryViewModel itemViewModelObject = new InventoryViewModel();

			ItemViewControl.DataContext = itemViewModelObject;
		}
		

		private void btn_AddItem_Click(object sender, RoutedEventArgs e)
		{
			AddItemWindow addItemWindow = new AddItemWindow();
			addItemWindow.ShowDialog();

		}
		*/
	}
}