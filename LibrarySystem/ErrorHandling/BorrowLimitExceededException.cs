namespace LibrarySystem.ErrorHandling;

public class BorrowLimitExceededException : Exception
{
    public BorrowLimitExceededException(string message) : base(message)
    {
    }
}
