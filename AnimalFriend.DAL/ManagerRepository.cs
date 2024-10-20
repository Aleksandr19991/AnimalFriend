using Microsoft.EntityFrameworkCore;
using AnimalFriend.Core.DTOs;

namespace AnimalFriend.DAL
{
    public class ManagerRepository
    {
        Context context = new();
        public void AddBidder(RequestToAddShelterDto bidder, int userId)
        {
            bidder.User = GetUser(userId); //получаем Ид user
            context.RequestsForAdd.Add(bidder);
            context.SaveChanges();
        }

        public UserDto GetUser(int userId)
        {
            return context.Users.Where(s => s.Id == userId).FirstOrDefault();
        }
    }
}
