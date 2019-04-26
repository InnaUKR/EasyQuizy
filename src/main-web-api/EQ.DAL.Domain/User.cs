using EQ.Common.Models.Enums;
using EQ.DAL.Infrastructure.Implementation;
using System;

namespace EQ.DAL.Domain
{
    public class User : UserEntity<Guid, string>
    {
        public UserStatus Status { get; set; }
    }
}