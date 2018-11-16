namespace SFX.Core.Domain.Response
{
    public class SaveResponseDto : ResponseBase
    {
        public int SavedEntityId { get; set; }

        public string SavedDataId { get; set; }

        public int RecordId { get; set; }

    }
}
