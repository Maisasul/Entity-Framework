namespace EfCore2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var book = new Book
            {
                author = "Fatma",
                title = "BOOK1",
                description = "we like"
            };
            _context.books.Add(book);
            _context.SaveChanges();
        }
    }
}