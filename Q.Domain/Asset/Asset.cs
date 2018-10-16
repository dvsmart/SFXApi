using System.Collections.Generic;

namespace SFX.Domain.Asset
{
    public class Asset : BaseEntity
    {
        public int? PortfolioId { get; set; }

        public int? SubPortfolioId { get; set; }

        public int? ManagingAgentId { get; set; }

        public int? ManagingAgentPortfolioId { get; set; }
   

        public int AssetTypeId { get; set; }

        public virtual AssetType AssetType { get; set; }

        public virtual ICollection<AssetProperty> AssetProperties { get; set; }
        
    }
}
