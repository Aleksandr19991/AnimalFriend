using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using Microsoft.EntityFrameworkCore;

namespace DBCreater
{
    public class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            //context.Database.EnsureCreated();



            //var authorize = context.Users.Where(s => s.Email == "admin@gmail.com").FirstOrDefault();
            //Console.WriteLine(authorize.Id);
            //var t = authorize.Role;
            //Console.WriteLine(t.Id);



            //ADD ROLE ADMIN
            //UserRoleDto role = new();
            //role.Id = 3;
            //role.Role = "admin";
            //var authorize = context.Users.Where(s => s.Email == "admin@gmail.com").FirstOrDefault();
            //Console.WriteLine(authorize.Email);
            //authorize.Role = role;
            //context.SaveChanges();



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



            //CREATE TYPE
            //var type1 = new AnimalTypeDto();
            //type1.Id = 1;
            //type1.Type = "cat";
            //context.AnimalTypes.Add(type1);
            //context.SaveChanges();

            //var type2 = new AnimalTypeDto();
            //type2.Id = 2;
            //type2.Type = "dog";
            //context.AnimalTypes.Add(type2);
            //context.SaveChanges();

            //var type3 = new AnimalTypeDto();
            //type3.Id = 3;
            //type3.Type = "all animals";
            //context.AnimalTypes.Add(type3);
            //context.SaveChanges();

            //var type4 = new AnimalTypeDto();
            //type4.Id = 4;
            //type4.Type = "other";
            //context.AnimalTypes.Add(type4);
            //context.SaveChanges();
        }
    }
}
