namespace KnockoutBindingTest.Models
{
	public class Order
	{
		public string OrderName { get; set; }
		public PrimaryOrderInfo PrimaryInfo { get; set; }
		public SecondaryOrderInfo SecondaryInfo { get; set; }
		
	}
}