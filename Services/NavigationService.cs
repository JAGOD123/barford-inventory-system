using Barford_Inventory_System.Stores;
using Barford_Inventory_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Services
{
    public class NavigationService
    {
		private readonly NavigationStore _navigationstore;
		private readonly Func<ViewModelBase> _createViewModel;

		public NavigationService(NavigationStore navigationstore, Func<ViewModelBase> createViewModel)
		{
			_navigationstore = navigationstore;
			_createViewModel = createViewModel;
		}
		public void Navigate()
        {
			_navigationstore.CurrentViewModel = _createViewModel();
		}
    }
}
