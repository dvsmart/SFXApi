using System.Collections.Generic;
using System.Linq;

namespace SFX.Dtos.CustomEntity
{
    public class CustomTabDto
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public short? SortOrder { get; set; }

        public bool IsVisible { get; set; }

        public int CustomTemplateId { get; set; }

        public bool IsOptional { get; set; }

        public IList<CustomFieldDto> CustomFields { get; set; } = new List<CustomFieldDto>();

    }

}
