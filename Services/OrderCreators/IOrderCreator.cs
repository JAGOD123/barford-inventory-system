using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Services.OrderCreators
{
	public interface IOrderCreator
	{
		Task CreateOrder(Order order);
	}
}
