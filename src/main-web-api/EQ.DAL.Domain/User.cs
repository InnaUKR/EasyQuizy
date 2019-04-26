using EQ.Common.Models.Enums;
using EQ.DAL.Infrastructure.Implementation;
using System;

namespace EQ.DAL.Domain
{
    public class User : UserEntity<Guid, Guid>
    {
        public UserStatus Status { get; set; }
        public UserType Type { get; set; }
    }
}