using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SFX.Domain;
using SFX.Domain.Asset;
using SFX.Infrastructure.Mappings;
using SFX.Web.Helpers;
using SFX.Web.Models.Asset;

namespace SFX.Web.Controllers.Asset
{
    public class Presenter : IPresenter
    {
        public IActionResult ViewModel { get; private set; }

        public void Populate(PagedResult<AssetProperty> output, IOutputConverter outputConverter)
        {
            if (output == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            var properties = outputConverter.Map<List<AssetProperties>>(output.Results);

            ViewModel = new ObjectResult(properties.GetPagedResult(output.PageSize, output.CurrentPage, output.RowCount));
        }

    }
}
