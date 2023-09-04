using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DoctorClinicApplication.Utilities
{
    public class NoSuchEntityException:Exception
    {
        string message;
        public NoSuchEntityException(string name)
        {
            message = $"No such {name} is available";
        }
        public override string Message => message;

    }
}
