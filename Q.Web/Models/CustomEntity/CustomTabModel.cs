using System.Collections.Generic;
using SFX.Web.Models.Base;

namespace SFX.Web.Models.CustomEntity
{
    public class CustomTabModel : BaseIdModel
    {
        public string Caption { get; set; }

        public List<CustomFieldModel> CustomFields { get; set; }

        public int? CustomEntityId { get; set; }

        public string RecordId { get; set; }

        public short? SortOrder { get; set; }

        public bool IsVisible { get; set; }

    }

    public class CustomTabRequestModel
    {
        public int TabId { get; set; }

        public bool NotApplicable { get; set; }
    }

    public class CreateCustomTabRequest : BaseIdModel
    {
        public string Caption { get; set; }

        public int CustomEntityId { get; set; }
    }

    public class TemplateTabModel
    {
        public TemplateTabModel()
        {
            CustomFields = new List<CustomFieldModel>();
        }

        public int TabId { get; set; }

        public string TabCaption { get; set; }

        public short? SortOrder { get; set; }

        public bool IsVisible { get; set; }

        public int CustomEntityId { get; set; }

        public List<CustomFieldModel> CustomFields { get; set; }
    }

    public class CustomTemplateTabModel
    {
        public int CustomEntityId { get; set; }

        public List<CustomTabResponse> CustomTabs { get; set; }
    }

    public class CustomTabResponse
    {
        public int Id { get; set; }

        public string TabName { get; set; }

        public int FieldsCount { get; set; }
    }
}
