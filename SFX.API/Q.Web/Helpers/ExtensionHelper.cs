using System.Collections.Generic;

namespace SFX.Web.Helpers
{
    public static class ExtensionHelper
    {
        public static PagedResultModel<T> GetPagedResult<T>(this List<T> result, int pageSize, int currentPage, int count) where T : class
        {
            return new PagedResultModel<T>
            {
                PageSize = pageSize,
                CurrentPage = currentPage,
                TotalCount = count,
                Data = result
            };
        }
    }
}