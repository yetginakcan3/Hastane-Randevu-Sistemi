﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
	public class Insurance
	{
		public int Id { get; set; }
		public string PolicyNumber { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		[NotMapped]
		public ICollection <Bill> Bill { get; set; }
	}
}
