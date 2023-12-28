﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Hospital.Models;


namespace Hospital.Repositories
{
	public class ApplicationDbContext : IdentityDbContext
	{
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Appointment> Appointments { get; set; }

		public DbSet<Bill> Bills { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Department> Departments { get; set; }

		public DbSet<HospitalInfo> Hospitals { get; set; }
		public DbSet<Insurance> Insurances { get; set; }
		public DbSet<Lab> Labs { get; set; }
		public DbSet<Medicine> Medicines { get; set; }
		public DbSet<Payroll> Payrolls { get; set; }
		public DbSet<PrescribedMedicine> PrescribedMedicines { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<TestPrice> TestPrices { get; set; }

	}
}
