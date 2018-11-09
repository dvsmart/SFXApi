using System;

namespace SFX.Web.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public string DataId { get; set; }
    }
}
