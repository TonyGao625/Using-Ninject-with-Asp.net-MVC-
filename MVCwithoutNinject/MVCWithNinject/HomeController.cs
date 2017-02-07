using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCWithNinject
{
	public class HomeController : Controller
	{
		ILogger _logger = null;

		public HomeController(ILogger logger)
		{
			_logger = logger;
		}
		public ActionResult Index()
		{
			try
			{

				ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			}

			catch (Exception ex)
			{

				_logger.LogData(ex.Message);

			}

			return View();

		}

	}
}