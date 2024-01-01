namespace Hospital.Models
{
	public class Appointment
	{
		public int Id { get; set; }
		public string Number { get; set; }
		public string Type { get; set; }

		public DateTime CreatedDate { get; set; }
		public string Description { get; set; }
	    public Contact Doctor { get; set; }
		public Contact Patient { get; set; }


		
	}
}