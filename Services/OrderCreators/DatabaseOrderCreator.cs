using Barford_Inventory_System.DbContexts;
using Barford_Inventory_System.DTOs;
using Barford_Inventory_System.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Services.OrderCreators
{
	public class DatabaseOrderCreator : IOrderCreator
	{
		private readonly BISDbContextFactory _dbContextFactory;

		public DatabaseOrderCreator(BISDbContextFactory dbContextFactory)
		{
			_dbContextFactory = dbContextFactory;
		}

		public async Task CreateOrder(Order order)
		{
			using (BISDbContext context = _dbContextFactory.CreateDbContext())
			{
				OrderDTO orderDTO = ToOrderDTO(order);

				context.Orders.Add(orderDTO);
				await context.SaveChangesAsync();
			}
		}

		private OrderDTO ToOrderDTO(Order order)
		{
			return new OrderDTO()
			{
				GroupId = order.GroupId,
				GroupName = order.GroupName,
				InDate = order.InDate,
				OutDate = order.OutDate,
				Items = order.Items
			};
		}
	}
}
