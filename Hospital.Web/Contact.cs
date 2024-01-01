using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital.Models
{
	public class Contact
	{
		
		public int Id { get; set; }
		public int HospitalId { get; set; }
		public Hospital Hospital { get; set; }

		public string Email { get; set; }
		public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public string PictureUri { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public string UserName { get; set; }
    }
}


