namespace DoctorClinicApplication.Utilities
{
    public class NoSuchDoctorException :Exception
    {
        string message;
        public NoSuchDoctorException()
        {
            message = "There is no doctor with the spec you have specified";
        }
        public override string Message => message;
    }
}
