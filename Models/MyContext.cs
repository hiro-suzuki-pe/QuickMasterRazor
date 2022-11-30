using Microsoft.EntityFrameworkCore;

namespace QuickMasterRazor.Models
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<Book>Book { get; set; }
    }
}
