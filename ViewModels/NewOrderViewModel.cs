using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Barford_Inventory_System.ViewModels
{
	public class NewOrderViewModel : ViewModelBase
	{
		private int _id;
		public int Id
		{
			get 
			{
				return _id; 
			}
			set 
			{
				_id = value;
				OnPropertyChanged(nameof(Id));
			}
			
		}
		private string _owner;
		public string Owner
		{
			get
			{
				return _owner;
			}
			set
			{
				_owner = value;
				OnPropertyChanged(nameof(Owner));
			}
		}
		private string _singedOut;
		public string SingedOut
		{
			get
			{
				return _singedOut;
			}
			set
			{
				_singedOut = value;
				OnPropertyChanged(nameof(SingedOut));
			}

		}
		private DateTime _startDate;
		public DateTime StartDate
		{
			get
			{
				return _startDate;
			}
			set
			{
				_startDate = value;
				OnPropertyChanged(nameof(StartDate));
			}
		}
		private DateTime _endDate;
		public DateTime EndDate
		{
			get
			{
				return _endDate;
			}
			set
			{
				_endDate = value;
				OnPropertyChanged(nameof(EndDate));
			}
		}

		private List<Item> _items;
		public  List<Item> Items
		{
			get
			{
				return new List<Item> {
					new Item(0, "Tent1", "Desc1", "Good"),
					new Item(1, "Tent2", "Desc2", "Good"),
					new Item(2, "Tent3", "Desc3", "Good")
				};
			}
			set
			{
				_items = value;
			}
		}
		public ICommand SubmitCommand { get; }
		public ICommand CancelCommand { get; }

		public NewOrderViewModel(Warehouse warehouse, NavigationService OverallOrdersNavService)
		{
			SubmitCommand = new NewOrderCommand(warehouse, this, OverallOrdersNavService);
			CancelCommand = new NavigateCommand(OverallOrdersNavService);
		}
	}
}
