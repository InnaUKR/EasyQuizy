using EQ.DAL.Infrastructure.Implementation;
using System;

namespace EQ.DAL.Domain
{
    public class AuthenticatedUser: BaseEntity<Guid>
    {
        public Guid SecurityId { get; set; }
        public string AccessToken { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}