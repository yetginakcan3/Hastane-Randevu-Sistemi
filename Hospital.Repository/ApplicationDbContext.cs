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

    }
}
