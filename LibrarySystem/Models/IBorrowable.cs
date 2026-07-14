namespace LibrarySystem.Models;

public interface IBorrowable
{
    void MarkAsBorrowed();
    void MarkAsReturned();

}
