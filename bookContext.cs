using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
    public class bookContext :DbContext
    {
        public bookContext(DbContextOptions<bookContext> options) : 
            base(options) 
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
    }
}
