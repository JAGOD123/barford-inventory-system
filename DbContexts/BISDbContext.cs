
using Barford_Inventory_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.DbContexts
{
    public class BISDbContext : DbContext
    {
		/*
        public BISDbContext(DbContextOptions options) : base(options) { }

		public DbSet<ItemDTO> Items { get; set; }
		public DbSet<OrderDTO> Orders { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Item>()
				.HasKey(i => i.ItemID);

			modelBuilder.Entity<Order>()
				.HasKey(o => o.GroupId);

			// Additional configuration if needed
		}
		*/
	}
}
