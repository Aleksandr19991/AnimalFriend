using AnimalFriend.Core.DTOs;
using AnimalFriend.DAL;

namespace DBCreater
{
    public class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Database.EnsureCreated();

            //var authorize = context.Users.Where(s => s.Email == "admin@gmail.com").FirstOrDefault();
            //Console.WriteLine(authorize.Id);
            //var a = authorize.Role;

            //onsole.WriteLine(authorize.Role);

            //ADD ROLE ADMIN
            //UserRoleDto role = new();
            //role.Id = 3;
            //role.Role = "admin";
            //var authorize = context.Users.Where(s => s.Email == "admin@gmail.com").FirstOrDefault();
            //Console.WriteLine(authorize.Email);
            //authorize.Role = role;
            //context.SaveChanges();

            //Console.WriteLine(authorize.Email);

            //CREATE USER ROLE
            //var roleIdA = new UserRoleDto();
            //roleIdA.Id = 3;
            //roleIdA.Role = "admin";
            //context.UserRoles.Add(roleIdA);
            //context.SaveChanges();

            //var roleIdM = new UserRoleDto();
            //roleIdM.Id = 2;
            //roleIdM.Role = "manager";
            //context.UserRoles.Add(roleIdM);
            //context.SaveChanges();

            //var roleIdU = new UserRoleDto();
            //roleIdU.Id = 1;
            //roleIdU.Role = "user";
            //context.UserRoles.Add(roleIdU);
            //context.SaveChanges();


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
