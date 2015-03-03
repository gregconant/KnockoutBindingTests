namespace KnockoutBindingTest.Models
{
	using System.Collections.Generic;

	public class PrimaryViewModel
	{
		public int Id { get; set; }

		public Person Person { get; set; }

		public List<Order> Orders { get; set; }
	}
}