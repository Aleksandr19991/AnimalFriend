using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Net.WebSockets;

namespace DBCreater
{
    public class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            //context.Database.EnsureCreated();

            //var result = context.RequestsForAdd.ToList();

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


            //var result = context.RequestsForAdd.ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id);
            //}

            //var authorize = context.Users.Where(s => s.Email == "admin@gmail.com").FirstOrDefault();
            //Console.WriteLine(authorize.Id);
            //var t = authorize.Role;
            //Console.WriteLine(t.Id);


            //var user = context.Users.Where(s => s.Email == "admin@gmail.com").
            //    Include(b => b.Role).FirstOrDefault();
            //Console.WriteLine(user.Role.Id);

            //var authorize = context.Users.Where(s => s.Email == "admin@gmail.com").FirstOrDefault();
            //Console.WriteLine(authorize.Id);
            //var a = authorize.Role;

            //authorize.Role.Id = context.UserRoles.Where(s => s.Id == 3).FirstOrDefault().Id;
            //context.SaveChanges();




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
        }
    }
}
