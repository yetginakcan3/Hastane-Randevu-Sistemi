using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
	public class PatientReport
	{
		public int Id {  get; set; }
		public string Diagnose{ get; set; }
		
		public Contact Doctor { get; set; }
		
		public Contact Patient { get; set; }
		[NotMapped]
		public ICollection<PrescribedMedicine> PrescribedMedicine { get;  set; }
	}
}
