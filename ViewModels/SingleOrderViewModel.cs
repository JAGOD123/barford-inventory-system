using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.ViewModels
{
	public class SingleOrderViewModel : ViewModelBase
	{
		private Order _order;

		public string Id => _order.Id.ToString();
		public string Owner => _order.Owner;
		public string SignedOut => _order.SingedOut;

		public string StartDate => _order.StartDate.ToString("d");
		public string EndDate => _order.EndDate.ToString("d");
		public List<Item> Items => _order.Items;

		public SingleOrderViewModel(Order order)
		{
			_order = order;
		}

	}
}
