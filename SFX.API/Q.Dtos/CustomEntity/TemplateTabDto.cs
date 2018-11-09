using System.Collections.Generic;

namespace SFX.Dtos.CustomEntity
{
    public class TemplateTabDto
    {
        public int  Id  { get; set; }

        public string TabName { get; set; }

        public bool IsVisible { get; set; }

        public bool IsOptional { get; set; }
        public short? SortOrder { get; set; }

        public List<TabFieldDto> Fields { get; set; } = new List<TabFieldDto>();
    }
    
}
