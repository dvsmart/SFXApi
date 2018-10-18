using System.Collections.Generic;

namespace SFX.Dtos.CustomEntity
{
    public class CustomTemplateTabDto
    {
        public CustomTemplateTabDto()
        {
            TemplateTabs = new List<CustomDto>();
        }

        public int Id { get; set; }

        public string TemplateName { get; set; }

        public IEnumerable<CustomDto> TemplateTabs { get; set; }

    }
}
