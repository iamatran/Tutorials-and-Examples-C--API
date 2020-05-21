namespace StudentApplication.API.Models  
{  
    public class LibraryContext: DbContext  
    {  
        public LibraryContext(DbContextOptions<LibraryContext> opts) : base(opts)  
        {  
        }  
        public DbSet<Author> Authors { get; set; }  
        public DbSet<Book> Books { get; set; } 
    }  
} 