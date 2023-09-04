namespace DoctorClinicApplication.Utilities
{
    public class NoDoctorsAreAvailable :Exception
    {
        string message;
        public NoDoctorsAreAvailable()
        {
            message = "No doctors available at this moment";
        }
        public override string Message => message;
    }
}
