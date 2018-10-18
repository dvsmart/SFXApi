using System.Collections.Generic;

namespace SFX.Domain.CustomEntity
{
    public class CustomEntity : BaseEntity
    {
        public string TemplateName { get; set; }

        public int? EntityGroupId { get; set; }

        public virtual CustomEntityGroup EntityGroup { get; set; }

        public virtual ICollection<CustomTab> CustomTabs { get; set; }
        public virtual ICollection<CustomEntityInstance> CustomEntityInstances { get; set; }
    }
}
