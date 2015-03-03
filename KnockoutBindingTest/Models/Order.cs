namespace KnockoutBindingTest.Models
{
	public class Order
	{
		public string OrderName { get; set; }
		public OrderInfo PrimaryInfo { get; set; }
		public OrderInfo SecondaryInfo { get; set; }
		
	}
}