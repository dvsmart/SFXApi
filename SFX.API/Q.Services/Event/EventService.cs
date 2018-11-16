using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SFX.Core.Domain.Response;
using SFX.Core.Interfaces;
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesEvent;

namespace SFX.Services.Event
{
    public class EventService : IEventService
    {
        private readonly IGenericRepository<Core.Domain.Event.Event> _eventRepository;

        public EventService(IGenericRepository<Core.Domain.Event.Event> eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            var eventDto = await _eventRepository.FindAsync(x=>x.Id== id);
            await _eventRepository.DeleteAsync(eventDto);
        }

        public async System.Threading.Tasks.Task DeleteAll(List<int> ids)
        {
            var entities = await _eventRepository.GetAllAsync();
            await _eventRepository.DeleteAsync(entities.FirstOrDefault());
            
        }

        public async Task<PagedResult<Core.Domain.Event.Event>> GetAll(int page, int? pageSize)
        {
            return await _eventRepository.GetPagedList(page, pageSize);
        }

        public async Task<Core.Domain.Event.Event> GetById(int id)
        {
            return await _eventRepository.FindAsync(x => x.Id == id);
        }

        public async Task<SaveResponseDto> Insert(Core.Domain.Event.Event entity)
        {
            var res = await _eventRepository.AddAsync(entity);
            return new SaveResponseDto
            {
                SaveSuccessful = res != null,
                SavedEntityId = entity.Id
            };
        }

        public async Task<SaveResponseDto> Update(Core.Domain.Event.Event entity)
        {
            var response = await _eventRepository.UpdateAsync(entity, entity.Id);
            return new SaveResponseDto
            {
                SaveSuccessful = response != null,
                SavedEntityId = entity.Id
            };
        }
    }
}
