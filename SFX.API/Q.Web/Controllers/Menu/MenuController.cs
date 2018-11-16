using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SFX.Core.Domain.Menu;
using SFX.Services.Interfaces.Menu;
using SFX.Web.Mappings;
using SFX.Web.Models.Menu;

namespace SFX.Web.Controllers.Menu
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Menu")]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        // GET: api/Menu
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var menuItems = await _menuService.GetAll();
            if (menuItems == null) return BadRequest();
            var menuModelList = Mapper.GetMenuItems(menuItems.ToList(), null);
            return new OkObjectResult(menuModelList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _menuService.GetMenuItem(id);
            var menuItemModel = new MenuItemModel
            {
                Id = item.Id,
                Caption = item.Title,
                Route = item.Route,
                IconName = item.Icon,
                IsVisible = item.IsVisible,
                ParentId = item.ParentId,
                MenuGroupId = item.MenuGroupId,
                HasChildren = item.HasChildren,
                SortOrder = item.SortOrder,
                AddedDate = item.AddedDate,
                MenuGroupName = item.MenuGroup.Name
            };
            return Ok(menuItemModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MenuItemModel menuItemModel)
        {
            var menuItem = new MenuItem
            {
                Id = menuItemModel.Id,
                AddedBy = 1,
                AddedDate = DateTime.UtcNow,
                IsDeleted = false,
                IsVisible = menuItemModel.IsVisible,
                IsArchived = false,
                HasChildren = menuItemModel.HasChildren,
                Icon = menuItemModel.IconName,
                ParentId = menuItemModel.ParentId,
                MenuGroupId = menuItemModel.MenuGroupId,
                Route = $"/{menuItemModel.Route}",
                OpenInNewTab = false,
                SortOrder = menuItemModel.SortOrder,
                Title = menuItemModel.Caption
            };
            var item = await _menuService.AddMenuItem(menuItem);
            return Ok(item);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] MenuItemModel menuItemModel)
        {
            var menuItem = new MenuItem
            {
                Id = menuItemModel.Id,
                AddedBy = 1,
                AddedDate = DateTime.UtcNow,
                IsDeleted = false,
                IsVisible = menuItemModel.IsVisible,
                IsArchived = false,
                HasChildren = menuItemModel.HasChildren,
                Icon = menuItemModel.IconName,
                ParentId = menuItemModel.ParentId,
                MenuGroupId = menuItemModel.MenuGroupId,
                Route = menuItemModel.Route,
                OpenInNewTab = false,
                SortOrder = menuItemModel.SortOrder,
                Title = menuItemModel.Caption
            };
            var item = await _menuService.Update(menuItem);
            return Ok(item);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _menuService.Delete(id);
            return Ok();
        }

    }
}
