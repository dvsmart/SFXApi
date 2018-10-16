using System;
using SFX.Web.Models.Base;

namespace SFX.Web.Models.Asset
{
    public class CreateAssetPropertyRequest : BaseModel
    {
        public int AssetId { get; set; }
        public string PropertyReference { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        public string City { get; set; }

        public string Postcode { get; set; }
        public string KnownAs { get; set; }

        public decimal? PropertySize { get; set; }
        public decimal? NetInternalSize { get; set; }
        public decimal? GrossInternalSize { get; set; }
        public short? NumberOfFloors { get; set; }
        public short? NumberOfPlantRooms { get; set; }

        public DateTime? StatusStartDate { get; set; }

        public int? CountyId { get; set; } = 1;
        public int? CountryId { get; set; } = 3;

    }
}
