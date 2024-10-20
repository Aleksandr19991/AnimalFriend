namespace AnimalFriend.Core.InputModel
{
    public class AnimalInputModel
    {
        public string Name { get; set; }

        public int? Age { get; set; }

        public string? Description { get; set; }

        public string? ImagePath { get; set; }

        public string? Type { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}


