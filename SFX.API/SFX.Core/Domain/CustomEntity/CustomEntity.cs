using SFX.Core.Interfaces;
using System.Collections.Generic;

namespace SFX.Core.Domain.CustomEntity
{
    public class CustomEntity : BaseEntity
    {
        public string TemplateName { get; set; }

        public int? EntityGroupId { get; set; }

        public virtual CustomEntityGroup EntityGroup { get; set; }

        public virtual ICollection<CustomTab> CustomTabs { get; set; }

        public virtual ICollection<CustomField> CustomFields { get; set; }

        public virtual ICollection<CustomEntityInstance> CustomEntityInstances { get; set; }
    }
}
