using System;

namespace EQ.Identity.Models.Response
{
    public class CreateUserResponse : BaseResponse
    {
        public Guid UserId { get; set; }
    }
}