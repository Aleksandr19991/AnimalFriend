using AnimalFriend.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AnimalFriend.DAL
{
    public class FundraisingRepository
    {
        Context context = new Context();

        public int CreateFundraising(FundraisingDto fundraising)
        {
            context.Fundraisings.Add(fundraising);
            context.SaveChanges();

            return fundraising.Id;
        }

        public List<FundraisingDto> GetAllFundraisings()
        {
            return context.Fundraisings.ToList();
        }

        public FundraisingDto GetFundraisingByShelterId(int shelterId)
        {
            var fundraising = context.Fundraisings.Include(f => f.Shelter).Where(f => f.Shelter.Id == shelterId).FirstOrDefault();

            return fundraising;
        }

        public int UpdateFundraising(FundraisingDto fundraising)
        {
            context.Fundraisings.Update(fundraising);
            context.SaveChanges();
            return fundraising.Id;
        }
    }
}
