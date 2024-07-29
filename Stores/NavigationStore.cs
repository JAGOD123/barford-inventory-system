﻿using Barford_Inventory_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel 
        { 
            get => _currentViewModel;
            set {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            } 
        }

		public event Action CurrentViewModelChanged;
		private void OnCurrentViewModelChanged()
		{
            CurrentViewModelChanged?.Invoke();
		}

    }
}
