namespace SFX.Domain.CustomEntity
{
    public class CustomField : BaseEntity
    {
        public string FieldName { get; set; }

        public int FieldTypeId { get; set; }

        public int CustomTabId { get; set; }

        public bool? IsMandatory { get; set; }

        public string ToolTip { get; set; }

        public string DefaultValue { get; set; }

        public short? SortOrder { get; set; }

        public bool? IsVisible { get; set; } = true;

        public virtual CustomFieldType FieldType { get; set; }

        public virtual CustomTab CustomTab { get; set; }
        
    }
}
