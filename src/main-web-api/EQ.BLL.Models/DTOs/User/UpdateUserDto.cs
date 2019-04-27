using System;

namespace EQ.BLL.Models.DTOs.User
{
    public class UpdateUserDto
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}