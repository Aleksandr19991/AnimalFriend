using AnimalFriend.BLL.Mappings;
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using AutoMapper;

namespace AnimalFriend.BLL
{
    public class ManagerService
    {
        private ManagerRepository ManagerRepository { get; set; }

        private Mapper _mapper;

        public ManagerService()
        {
            ManagerRepository = new ();

            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new ManagerMapperProfile());
            });
            _mapper = new Mapper(config);
        }

        public void AddBidder(RequestAddShelterInputModel bidder, int userId )
        {
            var shelter = _mapper.Map<RequestToAddShelterDto>(bidder);
            ManagerRepository.AddBidder(shelter, userId);
        }
    }
}
