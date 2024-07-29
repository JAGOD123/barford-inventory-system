using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Barford_Inventory_System.ViewModels
{
	class CreateNewItemViewModel : ViewModelBase
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

		public ICommand submitCommand { get; }
		public ICommand cancelCommand { get; }

        public CreateNewItemViewModel(Inventory inventory)
        {
            submitCommand = new MakeNewItemCommand(this, inventory); 
        }


    }
}
