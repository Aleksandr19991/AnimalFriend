using AnimalFriend.BLL.Mappings;
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using AutoMapper;

namespace AnimalFriend.BLL
{
    public class FundraisingService
    {
        private FundraisingRepository FundraisingRepository { get; set; }

        private Mapper _mapper;

        public FundraisingService()
        {
            FundraisingRepository = new FundraisingRepository();

            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new FundraisingMapperProfile());
            });
            _mapper = new Mapper(config);
        }

        public void CreateFundraising(FundraisingInputModel fundraising)
        {
            var fundraisingDto = _mapper.Map<FundraisingDto>(fundraising);

            FundraisingRepository.CreateFundraising(fundraisingDto);
        }

        public int UpdateFundraising(FundraisingInputModel fundraising)
        {
            var fundraisingDto = _mapper.Map<FundraisingDto>(fundraising);

            var fundraisingId = FundraisingRepository.UpdateFundraising(fundraisingDto);

            return fundraisingId;
        }

        public List<FundraisingOutputModel> GetAllFundraisings()
        {
            var fundraisingDtos = FundraisingRepository.GetAllFundraisings();

            List<FundraisingOutputModel> fundraisings = new();

            foreach (var fundraisingDto in fundraisingDtos)
            {
                FundraisingOutputModel fundraising = _mapper.Map<FundraisingOutputModel>(fundraisingDto);

                fundraisings.Add(fundraising);
            }

            return fundraisings;
        }
    }
}
