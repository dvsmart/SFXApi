using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
using SFX.Core.Domain.Response;
using SFX.Core.Interfaces;
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesAssessment;

namespace SFX.Services.Assessment
{
    public class AssessmentService : IAssessmentService
    {
        private readonly IGenericRepository<Core.Domain.Assessment.Assessment> _assessmentRepository;

        public AssessmentService(IGenericRepository<Core.Domain.Assessment.Assessment> assessmentRepository)
        {
            _assessmentRepository = assessmentRepository;
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            var assessment = await _assessmentRepository.FindAsync(x => x.Id == id);
            await _assessmentRepository.DeleteAsync(assessment);
        }

        public async System.Threading.Tasks.Task DeleteAll(List<int> ids)
        {
            var assessments = await _assessmentRepository.FindByAsync(x => ids.Contains(x.Id));
            await _assessmentRepository.DeleteAllAsync(assessments.ToList());
        }

        public async Task<PagedResult<Core.Domain.Assessment.Assessment>> GetAll(int page, int? pageSize)
        {
            return await _assessmentRepository.GetPagedList(page, pageSize);
        }

        public async Task<Core.Domain.Assessment.Assessment> GetById(int id)
        {
            return await _assessmentRepository.FindAsync(x=>x.Id == id);
        }

        public async Task<SaveResponseDto> Insert(Core.Domain.Assessment.Assessment entity)
        {
            var id = _assessmentRepository.GetLast().Id;
            entity.DataId = "";// DataIdGenerationService.GenerateDataId(id, "AM");
            var response = await _assessmentRepository.AddAsync(entity);
            return new SaveResponseDto
            {
                SavedDataId = entity.DataId,
                SavedEntityId = entity.Id,
                SaveSuccessful = response != null
            };
        }

        public async Task<SaveResponseDto> Update(Core.Domain.Assessment.Assessment entity)
        {
            if(entity.DataId == null)
            {
                var id = _assessmentRepository.GetLast().Id;
                entity.DataId = "";//DataIdGenerationService.GenerateDataId(id, "AM");
            }
            var response = await _assessmentRepository.UpdateAsync(entity,entity.Id);
            return new SaveResponseDto
            {
                SavedDataId = entity.DataId,
                SavedEntityId = entity.Id,
                SaveSuccessful = response != null,
                ErrorMessage = response == null ? string.Empty : "update failed"
            };
        }
    }
}
