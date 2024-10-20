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

        public void AddBidder(RequestCreateShelterInputModel bidder, int userId )
        {
            var shelter = _mapper.Map<RequestToAddShelterDto>(bidder);
            ManagerRepository.AddBidder(shelter, userId);
        }
        //public AuthorizationOutputModel GetInfoForAuthorise(string email)
        //{
        //    var info = UserRepository.GetInfoForAuthorise(email);
        //    var result = _mapper.Map<AuthorizationOutputModel>(info);
        //    return result;
        //}
        //public UserRoleModel GetUserRole(int id)
        //{
        //    var role = UserRepository.GetUserRole(id);
        //    var result = _mapper.Map<UserRoleModel>(role);
        //    return result;
        //}
    }
}
