using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIE206PROJECTGUI.Pages
{
	public class contactModel : PageModel
    {
		private readonly ILogger<contactModel> _logger;

		public contactModel(ILogger<contactModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}