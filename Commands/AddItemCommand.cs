using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Barford_Inventory_System.Commands
{
	public class AddItemCommand : CommandBase
	{
		private readonly Inventory _inventory;

		public AddItemCommand(Inventory inventory)
		{
			_inventory = inventory;
		}

		public override void Execute(object? parameter)
		{
			Item item = new Item("NewName", "A New Description");
			// _inventory.AddItem
		}
	}
}
