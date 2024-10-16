
using AnimalFriend.Core.DTOs;


namespace AnimalFriend.DAL
{

    public class UserRepository
    {
        Context context = new();

        public int AddUser(UserDto user)
        { 
            context.Users.Add(user);
            context.SaveChanges();
            return user.Id;
        }

        public UserDto GetInfoForAuthorise(string email)
        {
            var authorize = context.Users.Where(s => s.Email == email).FirstOrDefault();
            return authorize;
        }


    }
}
