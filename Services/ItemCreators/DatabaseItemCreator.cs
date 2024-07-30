using Barford_Inventory_System.DbContexts;
using Barford_Inventory_System.DTOs;
using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Services.ItemCreators
{
	public class DatabaseItemCreator : IItemCreator
	{ 
		private readonly BISDbContextFactory _dbContextFactory;

		public DatabaseItemCreator(BISDbContextFactory dbContextFactory)
		{
			_dbContextFactory = dbContextFactory;
		}
		public async Task CreateItem(Item item)
		{
			using (BISDbContext context = _dbContextFactory.CreateDbContext())
			{
				ItemDTO itemDTO = ToItemDTO(item);

				context.Items.Add(itemDTO);
				await context.SaveChangesAsync();
			}
		}

		private ItemDTO ToItemDTO(Item item)
		{
			return new ItemDTO()
			{
				Name = item.Name,
				Description = item.Description
			};
		}
	}
}
