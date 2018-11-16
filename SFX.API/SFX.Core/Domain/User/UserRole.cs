using System.Collections.Generic;

namespace SFX.Core.Domain.User
{
    public class UserRole: BaseEntity
    {
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
