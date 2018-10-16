namespace SFX.Domain.Asset
{
    public class AssetType : BaseEntity
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
