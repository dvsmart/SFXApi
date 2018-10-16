using System.Collections.Generic;

namespace SFX.Web.Helpers
{
    public class PagedResultModel<T>: PagingRequestBase where T: class
    {
        public List<T> Data { get; set; }

        public PagedResultModel()
        {
            Data = new List<T>();
        }
    }
}