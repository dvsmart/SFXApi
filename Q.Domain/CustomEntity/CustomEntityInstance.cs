using System;
using System.Collections.Generic;

namespace SFX.Domain.CustomEntity
{
    public class CustomEntityInstance : BaseEntity
    {
        public string DataId { get; set; }

        public int CustomEntityId { get; set; }

        public DateTime? DueDate { get; set; }

        public int Status { get; set; }

        public virtual CustomEntity CustomEntity { get; set; }

        public virtual ICollection<CustomFieldValue> CustomFieldValues { get; set; }

    }
}
