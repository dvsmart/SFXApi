namespace SFX.Dtos.CustomEntity
{
    public class CustomFieldResponseDto
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public string Key { get; set; }

        public string ControlType { get; set; }

        public bool IsRequired { get; set; }

        public int SortOrder { get; set; }

        public int? TemplateId { get; set; }

        public string TemplateName { get; set; }

        public int? TabId { get; set; }

        public string TabName { get; set; }
    }
}
