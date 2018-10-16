namespace SFX.Dtos.CustomEntity
{
    public class CustomFieldDto
    {
        public int FieldId { get; set; }

        public string Caption { get; set; }

        public short? SortOrder { get; set; }

        public bool IsVisible { get; set; } = true;

        public string Type { get; set; }

        public string Name { get => $"fieldId_" + FieldId;
            private set { } }

        public string Value { get; set; }

        public bool IsRequired { get; set; }
    }
}
