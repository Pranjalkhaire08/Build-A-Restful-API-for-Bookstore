
using BookAPI.Models;

internal class BookContext
{
    public object Books { get; internal set; }
    public object Book { get; internal set; }

    internal object Entry(Book book)
    {
        throw new NotImplementedException();
    }

    internal async Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}