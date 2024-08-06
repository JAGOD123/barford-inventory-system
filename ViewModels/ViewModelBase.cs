using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.ViewModels
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged(string propertyChanged)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
		}

		public virtual void Dispose () { }
	}
}
