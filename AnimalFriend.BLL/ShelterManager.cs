using AnimalFriend.Core.OutputModels;

namespace AnimalFriend.BLL
{
    public class ShelterManager
    {
        public List<ShelterCardOutputModel> GetAllShelter()
        {
            return new List<ShelterCardOutputModel>()
            {
                new ShelterCardOutputModel()
                {
                    Id = 1,
                    ImagePath = "images/dog.jpg",
                    TypeAnimal = "cat",
                    NameShelter = "cat shalter",
                    Description = "new cats shalter"
                },
                new ShelterCardOutputModel()
                {
                    Id = 2,
                    ImagePath = "images/dog.jpg",
                    TypeAnimal = "pig",
                    NameShelter = "pig shalter",
                    Description = "new pigs shalter"
                },
                new ShelterCardOutputModel()
                {
                    Id = 3,
                    ImagePath = "images/dog.jpg",
                    TypeAnimal = "dog",
                    NameShelter = "dog shalter",
                    Description = "new dogs shalter"
                },
            };
        }
    }
}
