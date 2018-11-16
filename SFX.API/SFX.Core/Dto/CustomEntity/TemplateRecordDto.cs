using System;
using System.Collections.Generic;
using System.Text;

namespace SFX.Services.Dtos.CustomEntity
{
    public class TemplateRecordDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<TabDto> Tabs { get; set; }
    }

    public class TabDto
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public List<FieldDto> Fields { get; set; }
    }

    public class FieldDto
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public bool IsRequired { get; set; }

        public bool IsVisible { get; set; }

        public string DefaultValue { get; set; }

        public Dictionary<int, string> Option { get; set; }

    }

    public class FieldOptionDto
    {
        public int Id { get; set; }

        public string OptionText { get; set; }

        public int FieldId { get; set; }
    }
}
