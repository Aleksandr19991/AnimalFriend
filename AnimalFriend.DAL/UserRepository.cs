

using AnimalFriend.Core.DTOs;
using Microsoft.Extensions.Options;
using Npgsql;

namespace AnimalFriend.DAL
{

    public class UserRepository
    {
        Context context = new();

        public void AddUser(UserDto user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }


    }
}
