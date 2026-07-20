namespace LibrarySystem.Models;

public class RegularMember : User
{
    public RegularMember(string name, string email, DateTime registrationDate) :
    base(name, email, registrationDate)
    {
    }

    public override int LoanPeriodDays { get; } = 14;
    public override int MaxBorrowLimit { get; } = 3;
    public const decimal FinePerDay = 0.5m; // $0.50 per day overdue

    public override decimal CalculateFine(int daysOverdue)
    {
        if (daysOverdue <= 0)
        {
            return 0;
        }
        return daysOverdue * FinePerDay;
    }

}
