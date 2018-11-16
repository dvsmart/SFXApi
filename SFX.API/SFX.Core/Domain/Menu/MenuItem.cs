using SFX.Core.Interfaces;
using System.Collections.Generic;

namespace SFX.Core.Domain.Menu
{
    public class MenuItem : BaseEntity
    {
        public string Title { get; set; }

        public string Route { get; set; }

        public bool? ExactMatch { get; set; }

        public bool HasChildren { get; set; }

        public string Classess { get; set; }

        public string Icon { get; set; }

        public string Translate { get; set; }

        public bool IsVisible { get; set; }

        public int SortOrder { get; set; }

        public int MenuGroupId { get; set; }
        public int? ParentId { get; set; }

        public string ExternalUrl { get; set; }

        public bool? OpenInNewTab { get; set; }

        public virtual MenuItem Parent { get; set; }

        public virtual ICollection<MenuItem> Children { get; set; }

        public virtual MenuGroup MenuGroup { get; set; }

    }
}
