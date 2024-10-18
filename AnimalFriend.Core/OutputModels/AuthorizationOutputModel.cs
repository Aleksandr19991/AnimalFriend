using System;


namespace AnimalFriend.Core.OutputModels
{
    public class AuthorizationOutputModel
    {
        public int Id { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }
    }
}
