﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barford_Inventory_System.DTOs
{
    public class ItemDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
		public string Description { get; set; }

	}
}
