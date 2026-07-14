namespace LibrarySystem.Models;

public enum AccessLevel
{
    Free,
    Premium
}
public class DigitalResource : Media
{
    public double FileSizeMB { get; init; }
    public string DownloadUrl { get; init; }
    public AccessLevel AccessLevel { get; init; }

    public DigitalResource(string title, int publicationYear, double fileSizeMB, string downloadUrl, AccessLevel accessLevel)
        : base(title, publicationYear)
    {
        FileSizeMB = fileSizeMB;
        DownloadUrl = downloadUrl;
        AccessLevel = accessLevel;
    }

    public override string GetDisplayInfo()
    {
        return $"Digital Resource: {Title}, File Size: {FileSizeMB} MB, Download URL: {DownloadUrl}, Access Level: {AccessLevel}, Published: {PublicationYear}";
    }

}
