using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.ViewModels
{
	public class OrdersOverviewViewModel : ViewModelBase
	{
		private readonly ObservableCollection<SingleOrderViewModel> _orders;

		public IEnumerable<SingleOrderViewModel> ViewOrders => _orders;
		
		public OrdersOverviewViewModel()
		{
			List<Item> _exampleItems = new List<Item> { new Item(0, "Tent1", "Desc1", "Good"),
				new Item(1, "Tent2", "Desc2", "Good"),
				new Item(2, "Tent3", "Desc3", "Good")
			};


			_orders = new ObservableCollection<SingleOrderViewModel>();
			_orders.Add(new SingleOrderViewModel(new Order(0, "Jack", "Callum", DateTime.Now, DateTime.Now, _exampleItems)));
			_orders.Add(new SingleOrderViewModel(new Order(1, "Neil", "Karen",  DateTime.Now, DateTime.Now, _exampleItems)));
			_orders.Add(new SingleOrderViewModel(new Order(2, "Jess", "Martin", DateTime.Now, DateTime.Now, _exampleItems)));
		}
	}
}
