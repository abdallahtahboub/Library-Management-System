namespace LibrarySystem.Models;

public abstract class User
{
    public List<BorrowRecord> BorrowedItems { get; } = new List<BorrowRecord>();
    public abstract int MaxBorrowLimit { get; }
    public abstract int LoanPeriodDays { get; }
    public int Id { get; }
    private static int nextId = 1;
    public string Name { get; init; }
    public string Email { get; init; }
    public DateTime RegistrationDate { get; init; }

    protected User(string name, string email, DateTime registrationDate)
    {
        Id = nextId++;
        Name = name;
        Email = email;
        RegistrationDate = registrationDate;
    }
    public abstract decimal CalculateFine(int daysOverdue);

}
