using Microsoft.AspNetCore.Mvc;
using SFX.Domain;
using SFX.Domain.Asset;
using SFX.Infrastructure.Mappings;

namespace SFX.Web.Controllers.Asset
{
    public interface IPresenter
    {
        void Populate(PagedResult<AssetProperty> output, IOutputConverter outputConverter);
        IActionResult ViewModel { get; }
    }
}