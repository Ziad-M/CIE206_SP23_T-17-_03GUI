using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIE206PROJECTGUI.Pages
{
	public class blog_detailsModel : PageModel
    {
		private readonly ILogger<blog_detailsModel> _logger;

		public blog_detailsModel(ILogger<blog_detailsModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}