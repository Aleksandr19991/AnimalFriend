
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using Microsoft.EntityFrameworkCore;

namespace AnimalFriend.DAL
{
    public class AdminRepository
    {
        Context context = new();
        public List<RequestToAddShelterDto> GetRequestAddSheltor()
        {
            return context.RequestsForAdd.Include(n=>n.User).ToList();
        }

        public void AddShelter(ShelterDto shelter, int typeId, int userId)
        {
            shelter.Type = context.AnimalTypes.Where(n => n.Id == typeId).FirstOrDefault();
            context.Add(shelter);
            var User = context.Users.Where(n => n.Id == userId).FirstOrDefault();
            //User.Role = context.UserRoles.Where(n => n.Id == 2).FirstOrDefault();
            User.Shelter = shelter;
            context.SaveChanges();
        }
    }
}
