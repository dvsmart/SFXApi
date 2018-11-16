namespace SFX.Core.Domain.Response
{
    public abstract class ResponseBase
    {
        public bool SaveSuccessful { get; set; }

        public string ErrorMessage { get; set; }
    }
}
