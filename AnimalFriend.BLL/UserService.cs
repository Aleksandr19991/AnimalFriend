using AnimalFriend.DAL;
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AutoMapper;
using AnimalFriend.BLL.Mappings;

namespace AnimalFriend.BLL
{
    public class UserService
    {
        private UserRepository UserRepository { get; set; }

        private Mapper _mapper;

        public UserService()
        {
            UserRepository = new UserRepository();

            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new UserMapperProfile());
            });
            _mapper = new Mapper(config);
        }

        public int AddUser(RegistrationInputModel user)
        {
            var userDto = _mapper.Map<UserDto>(user);
            int id = UserRepository.AddUser(userDto);
            return id;
        }
        public AuthorizationOutputModel GetInfoForAuthorise(string email)
        {
            var info = UserRepository.GetInfoForAuthorise(email);
            var result = _mapper.Map<AuthorizationOutputModel>(info);
            return result;
        }
        public UserRoleModel GetUserRole(int id)
        {
            var role = UserRepository.GetUserRole(id);
            var result = _mapper.Map<UserRoleModel>(role);
            return result;
        }
    }
}
