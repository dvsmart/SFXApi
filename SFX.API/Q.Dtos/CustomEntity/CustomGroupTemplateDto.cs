using System.Collections.Generic;

namespace SFX.Dtos.CustomEntity
{
    public class CustomGroupTemplateDto
    {
        public int GroupId  { get; set; }

        public string GroupName { get; set; }

        public List<CustomTemplateDto> CustomTemplates { get; set; }
    }
}
