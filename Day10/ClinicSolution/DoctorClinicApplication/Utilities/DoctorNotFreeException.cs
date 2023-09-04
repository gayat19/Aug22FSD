namespace DoctorClinicApplication.Utilities
{
    public class DoctorNotFreeException : Exception
    {
        public override string Message => "Doctor is already occupied";
    }
}
