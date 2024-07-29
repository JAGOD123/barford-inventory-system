using Barford_Inventory_System.Models;
using Barford_Inventory_System.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Barford_Inventory_System.Commands
{
    class MakeNewItemCommand : CommandBase
    {
		private readonly CreateNewItemViewModel _createNewItemViewModel;
		private readonly Inventory _inventory;

		public MakeNewItemCommand(CreateNewItemViewModel createNewItemViewModel, Inventory inventory)
		{
			_createNewItemViewModel = createNewItemViewModel;
			_inventory = inventory;

			_createNewItemViewModel.PropertyChanged += OnViewModelPropertyChanged;
		}


		public override bool CanExecute(object? parameter)
		{
			return !string.IsNullOrEmpty(_createNewItemViewModel.Name) && base.CanExecute(parameter);
		}


		public override void Execute(object? parameter)
		{
			Item item = new Item(
				_createNewItemViewModel.Name,
				_createNewItemViewModel.Description
				);
			_inventory.AddItem(item);
			MessageBox.Show(_inventory.GetItems()[0].Name);
		}
		private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(CreateNewItemViewModel.Name))
			{
				OnCanExecuteChanged();
			}
		}
	}
}
