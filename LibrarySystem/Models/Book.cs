namespace LibrarySystem.Models;

public class Book : Media, IBorrowable
{
    public required string Author { get; init; }
    public required string Isbn { get; init; }
    public required string Genre { get; init; }
    public int PageCount { get; init; }

    public Book( string title, int publicationYear, string author, string isbn, string genre, int pageCount)
        : base(title, publicationYear)
    {
        Author = author;
        Isbn = isbn;
        Genre = genre;
        PageCount = pageCount;
    }

    public override string GetDisplayInfo()
    {
        return $"Book: {Title} by {Author}, ISBN: {Isbn}, Genre: {Genre}, Pages: {PageCount}, Published: {PublicationYear}";
    }

    public void MarkAsBorrowed() => IsAvailable = false;
    public void MarkAsReturned() => IsAvailable = true;


}
