using System.Collections.Generic;

namespace SFX.Dtos.CustomEntity
{
    public class CustomEntityRecordDto
    {
        public CustomEntityRecordDto()
        {
            CustomTabs = new List<CustomTabDto>();
        }
        public int Id { get; set; }

        public string DataId { get; set; }

        public int CustomEntityId { get; set; }

        public List<CustomTabDto> CustomTabs { get; set; }

        public string TemplateName { get; set; }

    }


    public class CustomEntityDefintionDto
    {
        public CustomEntityDefintionDto()
        {
            CustomTabs = new List<CustomTabDto>();
        }

        public string TemplateName { get; set; }
        public int Id { get; set; }

        public string GroupName { get; set; }

        public int GroupId { get; set; }

        public List<CustomTabDto> CustomTabs { get; set; }
    }

    public class CustomEntityTemplate 
    {
        public int Id { get; set; }

        public int GroupId { get; set; }

        public string GroupName { get; set; }

        public string TemplateName { get; set; }
    }


}
