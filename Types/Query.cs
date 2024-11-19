namespace hc_check.Types;

[QueryType]
public static class Query
{
    public static async Task<Book> GetBook()
    {
        await Task.Delay(Random.Shared.Next(10, 200));
        return new Book("C# in depth.", new Author("Jon Skeet"));
    }

    public static async Task<Author> GetAuthor()
    {
        await Task.Delay(Random.Shared.Next(20, 300));
        return new Author("Jon Skeet");
    }
}