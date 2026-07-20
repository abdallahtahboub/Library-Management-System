namespace LibrarySystem.Models;

public class PremiumMember : User, IDigitalAccess
{

    public PremiumMember(string name, string email, DateTime registrationDate) :
   base(name, email, registrationDate)
    {
    }

    public override int LoanPeriodDays { get; } =21;
    public override int MaxBorrowLimit { get; } = 7;
    public const decimal FinePerDay = 0.25m; // $0.25 per day overdue

    public override decimal CalculateFine(int daysOverdue)
    {
        if (daysOverdue <= 0)
        {
            return 0;
        }
        return daysOverdue * FinePerDay;
    }

}
