namespace DoctorClinicApplication.Utilities
{
    public class NoEntriesAvailable :Exception
    {
        string message;
        public NoEntriesAvailable(string name)
        {
            message = $"No entries of {name} present";
        }
        public override string Message => message;
    }
}
