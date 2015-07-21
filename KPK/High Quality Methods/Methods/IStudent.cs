namespace Methods
{
    public interface IStudent
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string AdditionalInformation { get; set; }

        bool IsOlderThan(IStudent studentToCompare);
    }
}
