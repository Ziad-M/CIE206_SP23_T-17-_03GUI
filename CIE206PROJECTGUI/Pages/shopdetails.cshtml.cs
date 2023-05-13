using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIE206PROJECTGUI.Pages
{
	public class shopdetailsModel : PageModel
	{
		private readonly ILogger<shopdetailsModel> _logger;

		public shopdetailsModel(ILogger<shopdetailsModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}