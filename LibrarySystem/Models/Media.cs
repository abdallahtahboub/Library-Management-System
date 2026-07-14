namespace LibrarySystem.Models;

public abstract class Media
{
    private static int nextId = 1;

    public int Id { get; }
    public string Title { get; init; }
    public int PublicationYear { get; init; }
    public bool IsAvailable { get; set; } = true;


    protected Media(string title, int publicationYear)
    {
        Id = nextId++;
        Title = title;
        PublicationYear = publicationYear;
    }
    public abstract string GetDisplayInfo();


}
