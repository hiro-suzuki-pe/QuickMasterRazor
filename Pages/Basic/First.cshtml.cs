using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuickMasterRazor.Pages.Basic
{
    public class FirstModel : PageModel
    {
        public string Message { get; set; } = "";

        public IActionResult OnGet()
        {
            Message = "こんにちは、世界!";
            return Page();
        }
    }
}
