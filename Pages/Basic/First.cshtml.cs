using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuickMasterRazor.Pages.Basic
{
    public class FirstModel : PageModel
    {
        public string Message { get; set; } = "";

        public IActionResult OnGet()
        {
            Message = "����ɂ��́A���E!";
            return Page();
        }
    }
}
