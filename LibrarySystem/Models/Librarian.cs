namespace LibrarySystem.Models;

public class Librarian : User, ILibraryAdmin, IDigitalAccess
{
    public Librarian(string name, string email, DateTime registrationDate) :
    base(name, email, registrationDate)
    {
    }

    private const int UnlimitedLoanPeriodDays = 36500;
    public override int LoanPeriodDays { get; } = UnlimitedLoanPeriodDays;
    public override int MaxBorrowLimit { get; } = int.MaxValue;
    private const decimal FinePerDay = 0m; // Librarians do not incur fines

    public override decimal CalculateFine(int daysOverdue)
    {

        if (daysOverdue <= 0)
        {
            return 0;
        }
        return daysOverdue * FinePerDay;
    }

}
