namespace LibrarySystem.ErrorHandling;

public class ItemIsNotBorrowableException : Exception
{

    public ItemIsNotBorrowableException(string message) : base(message)
    {
    }
}
