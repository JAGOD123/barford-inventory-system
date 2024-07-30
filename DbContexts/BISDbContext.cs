using Barford_Inventory_System.DTOs;
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
        public BISDbContext(DbContextOptions options) : base(options) { }

		public DbSet<ItemDTO> Items { get; set; }
    }
}
