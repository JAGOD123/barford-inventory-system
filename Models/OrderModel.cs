using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.Models
{
	public class Order : ModelBase
	{
		public int GroupId { get; }
		public string GroupName { get; }
		public DateTime InDate { get;}
		public DateTime OutDate { get;}
		public List<Item> Items { get;}

		public Order() { }
		public Order(int groupId, string groupName, DateTime inDate, DateTime outDate, List<Item> items)
		{
			GroupId = groupId;
			GroupName = groupName;
			InDate = inDate;
			OutDate = outDate;
			Items = items;
		}
	}
}
