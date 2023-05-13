using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIE206PROJECTGUI.Pages
{
	public class shoppingcartModel : PageModel
    {
		private readonly ILogger<shoppingcartModel> _logger;

		public shoppingcartModel(ILogger<shoppingcartModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}