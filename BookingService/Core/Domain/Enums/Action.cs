namespace Domain.Enums
{
    public enum Action
    {
        Pay = 0,
        Finish = 1,  // After paid and used
        Cancel = 2,  // Can never be paid
        Refound = 3, // Paid then refound
        Reopeon = 4, // Canceled
    }
}
