using Barford_Inventory_System.DbContexts;
using Barford_Inventory_System.DTOs;
using Barford_Inventory_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Services.InventoryProviders
{
	public class DatabaseItemProvider : IItemProvider
	{
		private readonly BISDbContextFactory _dbContextFactory;

		public DatabaseItemProvider(BISDbContextFactory dbContextFactory)
		{
			_dbContextFactory = dbContextFactory;
		}

		public async Task<IEnumerable<Item>> GetAllItems()
		{
			using( BISDbContext context = _dbContextFactory.CreateDbContext())
			{
				IEnumerable<ItemDTO> itemDTOs = await context.Items.ToListAsync();

				return itemDTOs.Select(i => ToItem(i));
			}
		}

		private static Item ToItem(ItemDTO i)
		{
			return new Item(i.Name, i.Description);
		}
	}
}
