using System.Collections.Generic;

namespace SFX.Dtos.CustomEntity
{
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
}
