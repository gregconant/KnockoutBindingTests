using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace KnockoutBindingTest.Controllers
{
	using Models;

	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var viewModel = new PrimaryViewModel
			{
				Id = 2,
				Orders = new List<Order>
				{
					new Order
					{
						OrderName = "Some Order",
						PrimaryInfo = new OrderInfo
						{
							SomeInfo = "Primary Info String"
						},
						SecondaryInfo = new OrderInfo
						{
							SomeInfo = "Secondary Info String"
						}
					}
				},
				Person = new Person
				{
					FirstName = "First",
					LastName = "Last"
				}
			};
			return View("ViewModelHome", viewModel);
		}

		[HttpPost]
		public ActionResult Edit(PrimaryViewModel editedViewModel)
		{

			return View(editedViewModel);
		}
	}
}
