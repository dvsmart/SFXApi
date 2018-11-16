using SFX.Core.Interfaces;
using System.Collections.Generic;

namespace SFX.Core.Domain.Menu
{
    public class MenuGroup : BaseEntity
    {
        public string Name { get; set; }

        public bool IsVisible { get; set; }

        public virtual List<MenuItem> MenuItems { get; set; }

    }
}
