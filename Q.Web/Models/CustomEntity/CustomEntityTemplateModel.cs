using System.Collections.Generic;
using SFX.Web.Models.Base;

namespace SFX.Web.Models.CustomEntity
{
    public class CustomEntityTemplateModel : BaseIdModel
    {
        public string TemplateName { get; set; }
    }

    public class CustomTemplateModel
    {
        public CustomTemplateModel()
        {
            Templates = new List<CustomEntityTemplateModel>();
        }
        public string GroupName { get; set; }

        public int GroupId { get; set; }

        public int Count { get => Templates.Count; private set { } }

        public List<CustomEntityTemplateModel> Templates { get; set; }
    }
    
}
