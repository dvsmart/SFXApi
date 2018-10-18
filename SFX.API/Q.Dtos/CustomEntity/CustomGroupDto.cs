using System.Collections.Generic;

namespace SFX.Dtos.CustomEntity
{
    public class CustomGroupDto
    {
        public int Id { get; set; }

        public string GroupName { get; set; }
    }


    public class CreateCustomTemplateRequest
    {
        public int Id { get; set; }

        public int CustomGroupId { get; set; }

        public string TemplateName { get; set; }
    }


    public class CreateCustomGroupDto
    {
        public int Id { get; set; }

        public string GroupName { get; set; }

        public bool IsVisible { get; set; }

    }

    public class CreateCustomTemplateTabRequest
    {
        public int Id { get; set; }

        public string TabName { get; set; }

        public int CustomTemplateId { get; set; }

        public bool IsVisible { get; set; }
    }

    public class CustomTemplateDto
    {
        public int Id { get; set; }

        public string TemplateName { get; set; }

    }

    public class CustomGroupTemplateDto
    {
        public int GroupId  { get; set; }

        public string GroupName { get; set; }

        public List<CustomTemplateDto> CustomTemplates { get; set; }
    }

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

    public class CustomTemplateTabFieldsDto
    {
        public int Id { get; set; }

        public string TabName { get; set; }

        public List<CustomDto> CustomTabFields { get; set; }
    }
    

    public class CustomDto
    {
        public int Id { get; set; }

        public string Caption { get; set; }
    }


    public class CustomTabFieldResponseDto
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public string ControlType { get; set; }

        public int TabId { get; set; }
    }


    public class CreateCustomTabFieldRequest
    {

        public int Id { get; set; } = default(int);

        public string Caption { get; set; }

        public bool IsVisible { get; set; }

        public bool IsRequired { get; set; }

        public int ControlTypeId { get; set; }

        public int CustomTemplateTabId { get; set; }

        public List<CustomFieldOption> CustomFieldOptions { get; set; }

    }



    public class CustomFieldOption
    {
        public int Id { get; set; }

        public string Option { get; set; }

        public bool IsSelected { get; set; } = false;
    }
}
