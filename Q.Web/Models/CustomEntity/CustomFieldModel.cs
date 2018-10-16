using SFX.Web.Models.Base;

namespace SFX.Web.Models.CustomEntity
{
    public class CustomFieldModel : BaseIdModel
    {
        public string Label { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        public int TabId { get; set; }

        public short? SortOrder { get; set; }

        public bool IsMandatory { get; set; }

        public bool IsVisible { get; set; }

    }

    public class FieldTypeModel : BaseIdModel
    {
        public string TypeName { get; set; }
    }

    public class CustomFieldRequestModel: BaseIdModel
    {
        public string FieldName { get; set; }

        public int FieldTypeId { get; set; }

        public int CustomTabId { get; set; }
    }

    public class CustomFieldsForTab: BaseIdModel
    {
        public string  TabCaption { get; set; }

        public string FieldCaption { get; set; }

        public string FieldTypeName { get; set; }

        public int SortOrder { get; set; }

        public bool IsVisible { get; set; } = true;

        public int TabId { get; set; }
    }
}
