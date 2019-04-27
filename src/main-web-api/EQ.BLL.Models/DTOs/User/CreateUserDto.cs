using EQ.Common.Models.Enums;
using System;

namespace EQ.BLL.Models.DTOs.User
{
    public class CreateUserDto
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public UserType Type { get; set; }

        public string ContactNumber { get; set; }

        public DateTime DoB { get; set; }
    }
}