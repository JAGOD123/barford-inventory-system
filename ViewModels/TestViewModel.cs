using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Barford_Inventory_System.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
		public ICommand NavigateBackCommand { get;}
		public TestViewModel(NavigationService inventoryOverviewNavigationService)
		{
			NavigateBackCommand = new NavigateCommand(inventoryOverviewNavigationService);
		}

    }
}
