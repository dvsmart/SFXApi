using System.Collections.Generic;

namespace SFX.Dtos.CustomEntity
{
    public class CustomEntityDto
    {
        public int Id { get; set; }

        public string TemplateName { get; set; }
    }


    public class CustomEntityGroupDto
    {
        public CustomEntityGroupDto()
        {
            CustomEntities = new List<CustomEntityDto>();
        }

        public int Id { get; set; }

        public string GroupName { get; set; }

        public List<CustomEntityDto> CustomEntities { get; set; }
    }


}
