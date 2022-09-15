using Microsoft.AspNetCore.Mvc;

namespace AspStudy2.Controllers.ViewComponents
{
	public class LeftMenu : ViewComponent
	{
		public LeftMenu()
		{

		}

		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
