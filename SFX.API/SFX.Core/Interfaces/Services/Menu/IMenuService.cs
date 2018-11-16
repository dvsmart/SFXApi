using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.Menu;

namespace SFX.Core.Interfaces.ServicesMenu
{
    public interface IMenuService
    {
        System.Threading.Tasks.Task Add(MenuItem entity);

        Task<MenuItem> Update(MenuItem entity);

        System.Threading.Tasks.Task Delete(int id);

        System.Threading.Tasks.Task<IEnumerable<MenuItem>> GetAll();

        System.Threading.Tasks.Task<MenuItem> AddMenuItem(MenuItem menuItem);

        Task<IEnumerable<MenuGroup>> GetMenuGroups();

        Task<MenuItem> GetMenuItem(int id);
    }
}
