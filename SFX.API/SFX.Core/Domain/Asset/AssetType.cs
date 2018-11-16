using SFX.Core.Interfaces;

namespace SFX.Core.Domain.Asset
{
    public class AssetType : BaseEntity
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
