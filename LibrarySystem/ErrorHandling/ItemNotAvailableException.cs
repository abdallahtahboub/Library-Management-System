namespace LibrarySystem.ErrorHandling;

public class ItemNotAvailableException : Exception
{

    public ItemNotAvailableException(string message) : base(message)
    {
    }

}
