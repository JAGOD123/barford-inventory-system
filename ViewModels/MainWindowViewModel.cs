using Barford_Inventory_System.Models;
using Barford_Inventory_System.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Barford_Inventory_System.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
		public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

		public MainWindowViewModel(NavigationStore navigationStore)
		{
			_navigationStore = navigationStore;

			_navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
		}

		private void OnCurrentViewModelChanged()
		{
			OnPropertyChanged(nameof(CurrentViewModel));
		}
	}
}
