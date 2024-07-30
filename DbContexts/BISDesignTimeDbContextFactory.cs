using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.DbContexts
{
    public class BISDesignTimeDbContextFactory : IDesignTimeDbContextFactory<BISDbContext>
    {
        public BISDbContext CreateDbContext(string[] args)
        {
			DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=BIS.db").Options;
			return new BISDbContext(options);
		}
	}
}
