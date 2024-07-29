using Barford_Inventory_System.Models;
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
        public ViewModelBase CurrentViewModel { get; }
        public MainWindowViewModel(Inventory inventory)
        {
            CurrentViewModel = new CreateNewItemViewModel(inventory);
        }
	}
}
