using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIE206PROJECTGUI.Pages
{
	public class checkoutModel : PageModel
    {
		private readonly ILogger<checkoutModel> _logger;

		public checkoutModel(ILogger<checkoutModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}