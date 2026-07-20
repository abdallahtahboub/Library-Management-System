namespace LibrarySystem.Models;

public interface ISearchable
{   List<Media> Search(string title);
    List<Media> Search(string title, string genre);
    List<Media> SearchByAuthor(string author);
    List<Media> SearchByGenre(string genre);
    List<Media> Search(bool isAvailable);
}
