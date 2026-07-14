using LibrarySystem.ErrorHandling;
namespace LibrarySystem.Models;

public class BorrowingService
{
    public void BorrowMedia(User user, Media media)
    {
        if (media is not IBorrowable borrowableMedia)
        {
            throw new ItemIsNotBorrowableException($"{media.Title} is not borrowable.");
        }
        if (!media.IsAvailable)
        {
            throw new ItemNotAvailableException($"{media.Title} is not available for borrowing.");
        }

        if (user.BorrowedItems.Count(record => record.ReturnedDate == null) >= user.MaxBorrowLimit)
        {
            throw new BorrowLimitExceededException($"{user.Name} has reached the maximum borrow limit of {user.MaxBorrowLimit} items.");
        }

        BorrowRecord borrowRecord = new BorrowRecord
        {
            Item = media,
            BorrowedDate = DateTime.Now,
            DueDate = DateTime.Now.AddDays(user.LoanPeriodDays),
            ReturnedDate = null
        };

        user.BorrowedItems.Add(borrowRecord);
        borrowableMedia.MarkAsBorrowed();

    }
}
