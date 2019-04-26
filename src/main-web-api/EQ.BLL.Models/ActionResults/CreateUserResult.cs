using System;

namespace EQ.BLL.Models.ActionResults
{
    public class CreateUserResult : BaseResult
    {
        public CreateUserResult(bool isSucceed, string errorMessage) : base(isSucceed, errorMessage)
        {
        }

        public CreateUserResult(bool isSucceed, Guid userId)
        {
            IsSucceed = isSucceed;
            UserId = userId;
        }

        public Guid UserId { get; set; }
    }
}