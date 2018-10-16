using System;
using SFX.Web.Models.Base;

namespace SFX.Web.Models.CustomEntity
{
    public class CustomEntityInstanceModel : BaseIdModel
    {
        public string DataId { get; set; }

        public int CustomEntityId { get; set; }

        public int StatusId { get; set; }
    }

    public class CustomEntityInstanceGridModel : BaseIdModel
    {
        public string DataId { get; set; }

        public DateTime AddedOn { get; set; }

        public DateTime? DueDate { get; set; }

        public string Status { get; set; }

    }

    public class CustomEntityRecord : BaseIdModel
    {

        public string DataId { get; set; }

        public int CustomEntityId { get; set; }

        public CustomTabModel TabFieldsModel { get; set; }
    }
}
