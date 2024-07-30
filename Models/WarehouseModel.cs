using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Models
{
    public class Warehouse : ModelBase
    {
        private readonly Storage _storage;

        public string Name { get; }
		public Warehouse(string name, Storage storage)
		{
			Name = name;
			_storage = storage;
		}

		public async Task<IEnumerable<Item>> GetAllItems()
		{
			return await _storage.GetAllItems();
		}

		public async Task MakeItem(Item item)
		{
			await _storage.AddItem(item);
		}
	}
}
