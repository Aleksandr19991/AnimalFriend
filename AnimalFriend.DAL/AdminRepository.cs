
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;

namespace AnimalFriend.DAL
{
    public class AdminRepository
    {
        Context context = new();
        public List<RequestToAddShelterDto> GetRequestAddSheltor()
        {
            return context.RequestsForAdd.ToList();
        }

        public void AddShelter(ShelterDto shelter, int typeId, int userId)
        {
            shelter.Type = context.AnimalTypes.Where(n => n.Id == typeId).FirstOrDefault();
            context.Add(shelter);
            var User = context.Users.Where(n => n.Id == userId).FirstOrDefault();
            User.Role = context.UserRoles.Where(n => n.Id == 2).FirstOrDefault();
            User.Shelter = shelter;
            context.SaveChanges();
        }
    }
}
