using System;
using System.Collections.Generic;

namespace SFX.Web.Models.Menu
{
    public class MenuModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Url { get; set; }

        public string Type { get; set; }

        public bool HasChildren { get; set; }

        public string Classess { get; set; }

        public string Icon { get; set; }

        public bool IsVisible { get; set; }

        public int SortOrder { get; set; }

        public int MenuGroupId { get; set; }
        public int? ParentId { get; set; }

        public string ExternalUrl { get; set; }

        public bool? OpenInNewTab { get; set; }

        public List<MenuModel> Children { get; set; }
        public DateTime AddedDate { get; set; }
    }

    public class NavigationMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Url { get; set; }

        public string Type { get; set; }

        public bool HasChildren { get; set; }
        
        public string Icon { get; set; }

        public bool IsVisible { get; set; }

        public int SortOrder { get; set; }
        
        public DateTime AddedDate { get; set; }

        public string ParentMenuItemName { get; set; }
    }
}
