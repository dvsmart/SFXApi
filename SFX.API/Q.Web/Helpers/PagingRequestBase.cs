namespace SFX.Web.Helpers
{
    public abstract class PagingRequestBase
    { 
        public int TotalCount { get; set; }

        public int PageSize { get; set; }

        public int CurrentPage { get; set; }
    }
}