using EQ.Common.Models.Enums;

namespace EQ.BLL.Models.DTOs.User
{
    public class UserDetailsDto
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public UserType Type { get; set; }
    }
}