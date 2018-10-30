using System.Collections.Generic;

namespace SFX.Dtos.CustomEntity
{
    public class CreateFieldRequest
    {

        public int Id { get; set; } = default(int);

        public string Caption { get; set; }

        public bool IsVisible { get; set; }

        public bool IsRequired { get; set; }

        public int ControlTypeId { get; set; }

        public int? TabId { get; set; }

        public int? TemplateId { get; set; }

        public List<CustomFieldOption> CustomFieldOptions { get; set; }

    }
}
