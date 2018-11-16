using System.Collections.Generic;
using System.Threading.Tasks;

using SFX.Core.Domain.Menu;
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesMenu;

namespace SFX.Services.Menu
{
    public class MenuService : IMenuService
    {
        private readonly IGenericRepository<MenuItem> _menuItemRepository;
        private readonly IGenericRepository<MenuGroup> _menuGroupRepository;

        public MenuService(IGenericRepository<MenuItem> menuItemRepository, IGenericRepository<MenuGroup> menuGroupRepository)
        {
            _menuItemRepository = menuItemRepository;
            _menuGroupRepository = menuGroupRepository;
        }

        public async Task<IEnumerable<MenuItem>> GetMenuItems()
        {
            return await _menuItemRepository.GetAllAsync();
        }

        public async Task<MenuItem> AddMenuItem(MenuItem menuItem)
        {
            return await _menuItemRepository.AddAsync(menuItem);
        }

        public async System.Threading.Tasks.Task Add(MenuItem entity)
        {
            await _menuItemRepository.AddAsync(entity);
        }

        public async Task<MenuItem> Update(MenuItem entity)
        {
            return await _menuItemRepository.UpdateAsync(entity, entity.Id);
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            var item = await  _menuItemRepository.FindByIdAsync(id);
            await _menuItemRepository.DeleteAsync(item);
        }

        public async Task<IEnumerable<MenuItem>> GetAll()
        {
            var menuItems = await _menuItemRepository.GetAllAsync();
            return menuItems;
        }

        public async Task<IEnumerable<MenuGroup>> GetMenuGroups()
        {
            return await _menuGroupRepository.GetAllAsync();
        }

        public async Task<MenuItem> GetMenuItem(int id)
        {
            var item = await _menuItemRepository.FindByIdAsync(id);
            return item;
        }
    }
}
