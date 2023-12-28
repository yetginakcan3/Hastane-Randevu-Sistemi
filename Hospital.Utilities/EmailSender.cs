using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Hospital.Utilities
{
	public class EmailSender :IEmailSender
	{
		public Task SendEmailAsync(string subject, string email,string htmlMessage)
		{
			return Task.CompletedTask;
		}
	}
}
