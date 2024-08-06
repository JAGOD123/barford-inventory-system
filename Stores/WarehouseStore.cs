using Barford_Inventory_System.Commands;
using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Barford_Inventory_System.Stores
{
	public class WarehouseStore
	{
		private readonly Warehouse _warehouse;
		private readonly List<Item> _items;

        private Lazy<Task> _initalizeLazy;

		public IEnumerable<Item> Items => _items;

		public event Action<Item> ItemMade;

        public WarehouseStore(Warehouse warehouse)
        {
            _warehouse = warehouse;
            _items = new List<Item>();

			_initalizeLazy = new Lazy<Task>(Initialize);
        }

        public async Task Load()
		{
			await _initalizeLazy.Value;
		}

		public async Task MakeItem(Item item)
		{
			await _warehouse.MakeItem(item);
			_items.Add(item);

			OnItemMade(item);
		}

		private void OnItemMade(Item item)
		{
			ItemMade?.Invoke(item);
		}

		private async Task Initialize()
		{
			IEnumerable<Item> items = await _warehouse.GetAllItems();

			_items.Clear();
			_items.AddRange(items);
		}
	}
}
