using Barford_Inventory_System.DbContexts;
using Barford_Inventory_System.DTOs;
using Barford_Inventory_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Services.ItemConflictValidators
{
    class DatabaseItemConflictValidator : IItemConflictValidator
    {
		private readonly BISDbContextFactory _dbContextFactory;

		public DatabaseItemConflictValidator(BISDbContextFactory dbContextFactory)
		{
			_dbContextFactory = dbContextFactory;
		}

		public async Task<bool> DoesCauseConflict(Item item)
		{
			using (BISDbContext context = _dbContextFactory.CreateDbContext())
			{
				//return await context.Items
				//	.Select(i => ToItem(i))
				//	.AnyAsync(i => i.Conflicts(item));]
				return false;
			}
		}


		private static Item ToItem(ItemDTO i)
		{
			return new Item(i.Name, i.Description);
		}
	}
}
