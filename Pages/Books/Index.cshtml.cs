﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuickMasterRazor.Models;

namespace QuickMasterRazor.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly QuickMasterRazor.Models.MyContext _context;

        public IndexModel(QuickMasterRazor.Models.MyContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
