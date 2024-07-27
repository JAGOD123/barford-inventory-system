using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Barford_Inventory_System.Models
{
	public class InventoryItem : ModelBase
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
                    RaisePropertyChanged("Name");
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
					RaisePropertyChanged("Description");
					RaisePropertyChanged("NameAndDesc");
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

		public InventoryItem(string Name, string Desc)
		{
			_name = Name;
			_description = Desc;
		}
    }
}
