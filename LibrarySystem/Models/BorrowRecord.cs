namespace LibrarySystem.Models;

public class BorrowRecord
{

    public required Media Item { get; init; }
    public DateTime BorrowedDate { get; init; }
    public DateTime DueDate { get; init; }
    public DateTime? ReturnedDate { get; set; }
}
