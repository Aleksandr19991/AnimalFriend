using AnimalFriend.Core.OutputModels;

namespace AnimalFriend.BLL
{
    public class ShelterManager
    {
        public ShelterCardOutputModel GetAllShelter()
        {
            return new ShelterCardOutputModel()
            {
                Id = 1,
                ImagePath = "images/dog.jpg",
                TypeAnimal = "cat",
                NameShelter = "cat shalter",
                Description = "new cats shalter"
            };
        }

    }
}
