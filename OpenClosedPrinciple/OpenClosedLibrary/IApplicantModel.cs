namespace OpenClosedLibrary
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts accounts { get; set; }

    }
}