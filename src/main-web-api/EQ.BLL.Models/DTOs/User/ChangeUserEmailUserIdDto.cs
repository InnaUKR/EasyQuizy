using System;

namespace EQ.BLL.Models.DTOs.User
{
    public class ChangeUserEmailUserIdDto
    {
        public Guid UserId { get; set; }

        public string Email { get; set; }
    }
}