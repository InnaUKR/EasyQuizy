using System;

namespace EQ.BLL.Models.DTOs.User
{
    public class ChangeUserEmailSecurityIdDto
    {
        public Guid UserSecuriryId { get; set; }

        public string Email { get; set; }
    }
}