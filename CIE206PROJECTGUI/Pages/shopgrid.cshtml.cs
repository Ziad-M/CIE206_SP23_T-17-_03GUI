using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIE206PROJECTGUI.Pages
{
	public class shopgridModel : PageModel
	{
		private readonly ILogger<shopgridModel> _logger;

		public shopgridModel(ILogger<shopgridModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}