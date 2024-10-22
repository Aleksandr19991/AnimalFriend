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



            //var authorize = context.Users.Where(s => s.Email == "@Pochta").FirstOrDefault();
            //Console.WriteLine(authorize.Id);
            //var t = authorize.Role;
            //Console.WriteLine(t.Id);



            //ADD ROLE ADMIN
            //UserRoleDto role = new();
            //role.Id = 3;
            //role.Role = "admin";
            //var authorize = context.Users.Where(s => s.Email == "@Pochta").FirstOrDefault();
            //Console.WriteLine(authorize.Email);
            //authorize.Role = role;
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

            //var fundraising = new FundraisingDto();
            //fundraising.Id = 1;
            //fundraising.Name = "medicines";
            //fundraising.Description = "medicines for animals";
            //fundraising.Amount = 500000;
            //fundraising.Shelter = context.Shelters.Where(s => s.Id == 4).FirstOrDefault();
            //fundraising.IsDeleted = true;
            //context.Fundraisings.Add(fundraising);
            //context.SaveChanges();

            //var fundraising = new FundraisingDto();
            //fundraising.Id = 2;
            //fundraising.Name = "animal filler";
            //fundraising.Description = "filler";
            //fundraising.Amount = 500000;
            //fundraising.Shelter = context.Shelters.Where(s => s.Id == 4).FirstOrDefault();
            //fundraising.IsDeleted = true;
            //context.Fundraisings.Add(fundraising);
            //context.SaveChanges();

            //var fundraising = new FundraisingDto();
            //fundraising.Id = 3;
            //fundraising.Name = "collars, leashes, muzzles, carriers";
            //fundraising.Description = "collars, leashes, muzzles, carriers for animals";
            //fundraising.Amount = 500000;
            //fundraising.Shelter = context.Shelters.Where(s => s.Id == 4).FirstOrDefault();
            //fundraising.IsDeleted = true;
            //context.Fundraisings.Add(fundraising);
            //context.SaveChanges();
        }
    }
}
