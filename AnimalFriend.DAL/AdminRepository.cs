
using AnimalFriend.Core.DTOs;

namespace AnimalFriend.DAL
{
    public class AdminRepository
    {
        Context context = new();
        public List<RequestToAddShelterDto> GetRequestAddSheltor()
        {
            return context.RequestsForAdd.ToList();
        }
    }
}
