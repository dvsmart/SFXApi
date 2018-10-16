namespace SFX.Domain.CustomEntity
{
    public class CustomFieldValue : BaseEntity
    {
        public int CustomFieldId { get; set; }

        public int CustomEntityRecordId { get; set; }

        public string Value { get; set; }

        public virtual CustomEntityInstance CustomEntityRecord { get; set; }

        public virtual CustomField CustomField { get; set; }

    }
}
