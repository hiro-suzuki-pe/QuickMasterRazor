using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuickMasterRazor.Models;

namespace QuickMasterRazor.Pages.Basic
{
    public class ListModel : PageModel
    {
        public IEnumerable<Book> Book { get; set; }
        private readonly MyContext _context;
        public ListModel(MyContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Book = _context.Book;
        }
    }
}
