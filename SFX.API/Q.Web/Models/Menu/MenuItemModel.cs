using SFX.Web.Models.Base;

namespace SFX.Web.Models.Menu
{
    public class MenuItemModel : BaseModel
    {
        public string Caption { get; set; }

        public string Route { get; set; }

        public bool HasChildren { get; set; }

        public string ClassName { get; set; }

        public string IconName { get; set; }

        public bool IsVisible { get; set; }

        public int SortOrder { get; set; }

        public int MenuGroupId { get; set; }
        public int? ParentId { get; set; }

        public string MenuGroupName { get; set; }
    }
}
