using System;
using System.Collections.Generic;
using System.Text;

namespace SFX.Dtos.CustomEntity
{
    public class CustomForm
    {
        
    }

    public class CreateFormCategoryRequestDto
    {
        public int Id { get; set; }

        public string GroupName { get; set; }

    }

    public class CreateFormTemplateRequestDto
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int? CategoryId { get; set; }

        public string PluralName { get; set; }

        public bool IsVisible { get; set; }

    }

    public class CreateFormTabRequestDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int TemplateId { get; set; }

        public bool IsOptional { get; set; }

    }


    public class CreateFormTabFieldRequestDto
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public bool IsRequired { get; set; }

        public int TypeId { get; set; }

        public int TabId { get; set; }

        public IEnumerable<CreateFormFieldOptionRequestDto> OptionRequestDtos { get; set; }

        public string DefaultValue { get; set; }

        public bool DisplayOnGrid { get; set; }
    }

    public class CreateFormFieldOptionRequestDto
    {
        public int Id { get; set; }
        public int FieldId { get; set; }
        public string ChoiceText { get; set; }
    }




}
