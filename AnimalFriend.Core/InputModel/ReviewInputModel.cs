

namespace AnimalFriend.Core.InputModel
{
    public class ReviewInputModel
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int UserId { get; set; }

        public int ShelterId { get; set; }

        public int Stars { get; set; }

        public int Data { get; set; }
    }
}
