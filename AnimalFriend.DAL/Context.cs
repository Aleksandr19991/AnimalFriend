
using Microsoft.EntityFrameworkCore;
using AnimalFriend.Core.DTOs;

namespace AnimalFriend.DAL
{
    public class Context : DbContext
    {
        public DbSet<AnimalDto> Animals { get; set; }

        public DbSet<AnimalTypeDto> AnimalTypes { get; set; }

        public DbSet<DonationsDto> Donations { get; set; }

        public DbSet<FundraisingDto> Fundraisings {  get; set; }

        public DbSet<RequestsForAdditionDto> RequestsForAdd { get; set; }

        public DbSet<ReviewDto> Reviews { get; set; }

        public DbSet<ShelterDto> Shelters { get; set; }

        public DbSet<UserDto> Users { get; set; }

        public DbSet<UserRoleDto> UserRoles { get; set; }

        public DbSet<UserShelterDto> UserShelters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("Connection"));
        }
    }
}
