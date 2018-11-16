using SFX.Core.Interfaces;
using System.Collections.Generic;

namespace SFX.Core.Domain.CustomEntity
{
    public class CustomEntityGroup : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<CustomEntity> CustomEntities { get; set; }
    }
}
