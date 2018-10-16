using SFX.Web.Models.Base;

namespace SFX.Web.Models.Asset
{
    public class AssetProperties : BaseModel
    {
        public int AssetId { get; set; }
        public string PropertyReference { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string KnownAs { get; set; }

        public string PortfolioName { get; set; }

        public string SubPortfolioName { get; set; }

        public string AssetType { get; set; }

        public string Address { get; set; }

    }
}
