using AnimalFriend.DAL;
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
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

        public void AddUser(RegistrationInputModel user)
        {
            var userDto = _mapper.Map<UserDto>(user);
            UserRepository.AddUser(userDto);
        }

    }
}
