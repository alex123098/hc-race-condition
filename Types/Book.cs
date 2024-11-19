namespace hc_check.Types;

public sealed class Book(string title, Author author)
{
    public string Title => title;

    public async Task<Author> GetAuthor()
    {
        await Task.Delay(Random.Shared.Next(20, 300));
        return author;
    }
}