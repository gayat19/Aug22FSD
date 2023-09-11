using UnderstandingStateManagmentApp.Models;

namespace UnderstandingStateManagmentApp.Services
{
    public class UserService
    {
        List<User> users = new List<User>()
        {
        new User(){Username="Ramu",Password="1234"},
        new User(){Username="Somu",Password="1122"}
        };
        public bool LoginCheck(User user)
        {
            var myUser = users.SingleOrDefault(u=>u.Username == user.Username && u.Password==user.Password);
            if(myUser == null)
                return false;
            return true;
        }
    }
}
