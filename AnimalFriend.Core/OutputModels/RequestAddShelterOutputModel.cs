
namespace AnimalFriend.Core.OutputModels
{
    public class RequestAddShelterOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public String DateTime { get; set; }
    }
}
