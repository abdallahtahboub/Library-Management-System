namespace LibrarySystem.Models;

public enum Rating
{
    G,
    PG,
    PG13,
    R,
    NC17
}
public class DVD : Media, IBorrowable
{
    public string Director { get; init; }
    public int DurationMinutes { get; init; }
    public Rating Rating { get; init; }


    public DVD(string title, int publicationYear, string director, int durationMinutes, Rating rating) :
    base(title, publicationYear)
    {
        Director = director;
        DurationMinutes = durationMinutes;
        Rating = rating;
    }

    public override string GetDisplayInfo()
    {
        return $"DVD: {Title} directed by {Director}, Duration: {DurationMinutes} minutes, Rating: {Rating}, Published: {PublicationYear}";
    }

    public void MarkAsBorrowed() => IsAvailable = false;
    public void MarkAsReturned() => IsAvailable = true;
}
