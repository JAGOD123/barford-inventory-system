using Barford_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.DTOs
{
	public class OrderDTO
	{
		[Key]
		public int GroupId { get; set; }
		public string GroupName { get; set; }
		public DateTime InDate { get; set; }
		public DateTime OutDate { get; set; }
		public List<Item> Items { get; set; }
	}
}
