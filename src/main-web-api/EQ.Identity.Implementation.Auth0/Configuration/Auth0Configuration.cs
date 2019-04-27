using System.Collections.Generic;

namespace EQ.Identity.Implementation.Auth0.Configuration
{
    public class Auth0Configuration
    {
        public string Domain { get; set; }
        public string ApiAccessToken { get; set; }
        public List<Client> Clients { get; set; }

        public class Client
        {
            public string ClientName { get; set; }
            public string ClientId { get; set; }
            public string ClientSecret { get; set; }
            public string Connection { get; set; }
            public string Audience { get; set; }
            public string Scope { get; set; }
        }
    }
}