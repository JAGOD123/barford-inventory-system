using Barford_Inventory_System.Services;
using Barford_Inventory_System.Stores;
using Barford_Inventory_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Commands
{
	public class NavigateCommand : CommandBase
	{
		private readonly NavigationService _navigationService;

		public NavigateCommand(NavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		public override void Execute(object? parameter)
		{
			_navigationService.Navigate();
		}
	}
}
