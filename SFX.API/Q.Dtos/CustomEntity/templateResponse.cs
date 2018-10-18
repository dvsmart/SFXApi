using System;
using System.Collections.Generic;
using System.Text;

namespace SFX.Dtos.CustomEntity
{
    public class TemplateResponse
    {
        public int Id { get; set; }  

        public string TemplateName { get; set; }

        public string AddedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime AddedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public HashSet<TabResponse> Tabs { get; set; } = new HashSet<TabResponse>();

        public  HashSet<FieldResponse> Fields { get; set; } = new HashSet<FieldResponse>();

    }

    public class TabResponse
    {
        public int TabId { get; set; }

        public  string TabName { get; set; }

        public int FieldsCount { get; set; }

        public bool IsVisible { get; set; }

        public  bool IsOptional { get; set; }

        public DateTime AddedOn { get; set; }

        public string AddedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public  string ModifiedBy { get; set; }

        public HashSet<FieldResponse> Fields { get; set; } = new HashSet<FieldResponse>();

    }

    public class FieldResponse
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }

        public string FieldCaption { get; set; }

        public string FieldType { get; set; }

        public bool IsVisible { get; set; }

        public bool IsRequired { get; set; }

        public DateTime AddedOn { get; set; }

        public string AddedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string ModifiedBy { get; set; }

        public int? TabId { get; set; }

        public  Dictionary<int,string> FieldChoiceOptions { get; set; }

        public string Value { get; set; }
    }
}
