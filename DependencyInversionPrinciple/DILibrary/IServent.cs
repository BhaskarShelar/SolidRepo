namespace DILibrary
{
    public interface IServent
    {
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }
        string ServentName { get; set; }

        void CompleteChore();
        void PerformedWork(double hours);
    }
}