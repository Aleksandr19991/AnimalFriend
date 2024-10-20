using AnimalFriend.BLL.Mappings;
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using AutoMapper;

namespace AnimalFriend.BLL
{
    public class AdminService
    {
        private AdminRepository AdminRepository { get; set; }

        private Mapper _mapper;

        public AdminService()
        {
            AdminRepository = new();

            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new AdminMapperProfile());
            });
            _mapper = new Mapper(config);
        }


        public List<RequestAddShelterOutputModel> GetRequestAddSheltor()
        {
            var requests = AdminRepository.GetRequestAddSheltor();
            var result = _mapper.Map<List<RequestAddShelterOutputModel>>(requests);
            return result;
        }
        //public UserRoleModel GetUserRole(int id)
        //{
        //    var role = UserRepository.GetUserRole(id);
        //    var result = _mapper.Map<UserRoleModel>(role);
        //    return result;
        //}
        //public void AddBidder(RequestAddShelterInputModel bidder, int userId)
        //{
        //    var shelter = _mapper.Map<RequestToAddShelterDto>(bidder);
        //    ManagerRepository.AddBidder(shelter, userId);
        //}
    }
}
