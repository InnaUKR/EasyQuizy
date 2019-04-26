using System.Collections.Generic;

namespace EQ.BLL.Models.DTOs.User
{
    public class UsersListPagedDto
    {
        public Pagination Pagination { get; set; }

        public IList<UserViewDto> Users { get; set; }
    }
}