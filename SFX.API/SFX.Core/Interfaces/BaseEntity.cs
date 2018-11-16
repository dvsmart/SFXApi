using SFX.Core.Domain;
using System;

namespace SFX.Core.Interfaces
{
    public class BaseEntity : IBaseEntity
    {
        public DateTime AddedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }

        public int AddedBy { get; set; }

        public int? ModifiedBy { get; set; }

        public bool IsArchived { get; set; }

        public bool IsDeleted { get; set; }

    }
}
