using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuickMasterRazor.Pages.Basic
{
    public class FirstModel : PageModel
    {
        public string Message { get; set; } = "";

        public IActionResult OnGet()
        {
            Message = "Ç±ÇÒÇ…ÇøÇÕÅAê¢äE!";
            return Page();
        }
    }
}
