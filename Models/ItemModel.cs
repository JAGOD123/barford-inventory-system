using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Barford_Inventory_System.Models
{
	public class Item : ModelBase
    {
		public string Name { get; }
		public string Description { get; }
        
		public string NameAndDesc { get; }
		public Item(string name, string desc)
		{
			Name = name;
			Description = desc;
			NameAndDesc= name +" "+ Description;
		}
    }
}
