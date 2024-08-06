using Barford_Inventory_System.DbContexts;
using Barford_Inventory_System.DTOs;
using Barford_Inventory_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Services.OrderProviders
{
	public class DatabaseOrderProvider : IOrderProvider
	{
		private readonly BISDbContextFactory _dbContextFactory;

		public DatabaseOrderProvider(BISDbContextFactory dbContextFactory)
		{
			_dbContextFactory = dbContextFactory;
		}

		public async Task<IEnumerable<Order>> GetAllOrders()
		{
			using (BISDbContext context = _dbContextFactory.CreateDbContext())
			{
				IEnumerable<OrderDTO> orderDTOs = await context.Orders.ToListAsync();

				return orderDTOs.Select(o => ToOrder(o));
			}
		}

		private Order ToOrder(OrderDTO Order)
		{
			return new Order(Order.GroupId, Order.GroupName, Order.InDate, Order.OutDate, Order.Items);
		}
	}

}
