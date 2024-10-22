
using AnimalFriend.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AnimalFriend.DAL
{
    public class ShelterRepository
    {
        Context context = new();
        public List<ShelterDto> GetAllShelter()
        {
            return context.Shelters.Include(u=>u.Type).ToList();
        }
    }
}
