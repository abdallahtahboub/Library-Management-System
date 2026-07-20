namespace LibrarySystem.ErrorHandling;

public class AccessDeniedException:Exception
{
    public AccessDeniedException(string message) : base(message)
    {
    }    
}
