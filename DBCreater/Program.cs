using AnimalFriend.Core.DTOs;
using AnimalFriend.DAL;

namespace DBCreater
{
    public class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            //context.Database.EnsureCreated();

            var authorize = context.Users.Where(s => s.Email == "123456@gmail.com").FirstOrDefault();
            Console.WriteLine(authorize.Email);

            //var roleId = new UserRoleDto();
            //roleId.Id = 3;
            //roleId.Role = "Admin";

            //var user = new UserDto();
            //user.Email = "admin@mail.ru";
            //user.Name = "Keny";
            //user.Password = "123456";
            //user.Phone = "321214556";
            //user.Role = roleId;

            //context.Users.Add(user);
            //context.SaveChanges();
        }
    }
}
