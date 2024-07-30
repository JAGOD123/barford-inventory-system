using Barford_Inventory_System.Services.InventoryProviders;
using Barford_Inventory_System.Services.ItemConflictValidators;
using Barford_Inventory_System.Services.ItemCreators;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Barford_Inventory_System.Models
{
    public class Storage : ModelBase
    {
		private readonly IItemProvider _itemProvider;
		private readonly IItemCreator _itemCreator;
		private readonly IItemConflictValidator _itemConflictValidator;

		public Storage(IItemProvider itemProvider, IItemCreator itemCreator, IItemConflictValidator itemConflictValidator)
		{
			_itemProvider = itemProvider;
			_itemCreator = itemCreator;
			_itemConflictValidator = itemConflictValidator;
		}

		public async Task AddItem(Item item)
		{
			await _itemCreator.CreateItem(item);
		}

		public async Task<IEnumerable<Item>> GetAllItems()
		{
			return await _itemProvider.GetAllItems();
		}

	}
}
