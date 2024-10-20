﻿namespace AnimalFriend.Core.OutputModels
{
    public class AnimalOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Age { get; set; }

        public string? Description { get; set; }

        public string? ImagePath { get; set; }

        public string? Type { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
