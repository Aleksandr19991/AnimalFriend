using Microsoft.EntityFrameworkCore;
using AnimalFriend.Core.DTOs;


namespace AnimalFriend.DAL
{

    public class UserRepository
    {
        Context context = new();
        public int AddUser(UserDto user)
        {
            var role = GetUserRole(1);
            user.Role = role;
            context.Users.Add(user);
            context.SaveChanges();
            return user.Id;
        }
        public UserDto GetInfoForAuthorise(string email)
        {
            var authorizeUser = context.Users.Where(s => s.Email == email).
               Include(b => b.Role).FirstOrDefault();
            
            Console.WriteLine(authorizeUser.Id);
            Console.WriteLine(authorizeUser.Role.Id);
            return authorizeUser;
        }

        public UserRoleDto GetUserRole(int id)
        {
            var role = context.UserRoles.Where(s => s.Id == id).FirstOrDefault();
            return role;
        }


    }
}
