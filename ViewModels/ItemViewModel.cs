using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.ViewModels
{
    public class ItemViewModel : ViewModelBase
    {
		private Item _item;

		public string Name => _item.Name;
		public string Description => _item.Description;

        public ItemViewModel(Item item)
        {
            _item = item;
        }
    }
}
