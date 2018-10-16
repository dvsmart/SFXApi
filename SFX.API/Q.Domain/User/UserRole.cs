using System.Collections.Generic;

namespace SFX.Domain.User
{
    public class UserRole: BaseEntity
    {
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
