using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using Barford_Inventory_System.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Barford_Inventory_System.ViewModels
{
	public class CreateNewItemViewModel : ViewModelBase
	{
		private string _name;
		private string _description;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (_name != value)
				{
					_name = value;
					OnPropertyChanged("Name");
				}
			}
		}
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (_description != value)
				{
					_description = value;
					OnPropertyChanged("Description");
					OnPropertyChanged("NameAndDesc");
				}
			}
		}

		public string NameAndDesc
		{
			get
			{
				return _name + " " + _description;
			}
		}

		public ICommand SubmitCommand { get; }
		public ICommand CancelCommand { get; }

        public CreateNewItemViewModel(WarehouseStore warehouseStore,
			NavigationService inventoryOverviewNavigationService)
        {
            SubmitCommand = new MakeNewItemCommand(this, warehouseStore, inventoryOverviewNavigationService);
			CancelCommand = new NavigateCommand(inventoryOverviewNavigationService);
        }


    }
}
