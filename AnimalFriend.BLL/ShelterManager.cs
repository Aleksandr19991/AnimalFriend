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
                    ImagePath = "images/pes.jpg",
                    TypeAnimal = "dog",
                    NameShelter = "dogs shelter",
                    Description = "new dogs shelter"
                },
                new ShelterCardOutputModel()
                {
                    Id = 2,
                    ImagePath = "images/shenok.jpg",
                    TypeAnimal = "puppy",
                    NameShelter = "puppys shelter",
                    Description = "new puppys shelter"
                },
                new ShelterCardOutputModel()
                {
                    Id = 3,
                    ImagePath = "images/cat.jpg",
                    TypeAnimal = "cat",
                    NameShelter = "cat shalter",
                    Description = "new cats shelter"
                },
                new ShelterCardOutputModel()
                {
                    Id = 4,
                    ImagePath = "images/kitty.JPEG",
                    TypeAnimal = "kitty",
                    NameShelter = "kittys shalter",
                    Description = "new kittys shelter"
                },
                 new ShelterCardOutputModel()
                {
                    Id = 1,
                    ImagePath = "images/pes.jpg",
                    TypeAnimal = "dog",
                    NameShelter = "dogs shelter",
                    Description = "new dogs shelter"
                },
                new ShelterCardOutputModel()
                {
                    Id = 2,
                    ImagePath = "images/shenok.jpg",
                    TypeAnimal = "puppy",
                    NameShelter = "puppys shelter",
                    Description = "new puppys shelter"
                },
                new ShelterCardOutputModel()
                {
                    Id = 3,
                    ImagePath = "images/cat.jpg",
                    TypeAnimal = "cat",
                    NameShelter = "cat shalter",
                    Description = "new cats shelter"
                },
                new ShelterCardOutputModel()
                {
                    Id = 4,
                    ImagePath = "images/kitty.JPEG",
                    TypeAnimal = "kitty",
                    NameShelter = "kittys shalter",
                    Description = "new kittys shelter"
                },
            };
        }
    }
}
