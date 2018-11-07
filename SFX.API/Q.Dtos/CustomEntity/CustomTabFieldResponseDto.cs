namespace SFX.Dtos.CustomEntity
{
    public class CustomTabFieldResponseDto
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public string ControlType { get; set; }

        public int ControlTypeId { get; set; }

        public bool IsRequired { get; set; }

        public int SortOrder { get; set; }

        public int TemplateId { get; set; }

        public int TabId { get; set; }
        public string Key { get; set; }
        public string TabName { get; set; }
    }
}
