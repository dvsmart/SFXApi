using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFX.Domain;
using SFX.Domain.Response;
using SFX.Services.Helper;
using SFX.Services.Interfaces.Assessment;

namespace SFX.Services.Service.Assessment
{
    public class AssessmentService : IAssessmentService
    {
        private readonly IGenericRepository<Domain.Assessment.Assessment> _assessmentRepository;

        public AssessmentService(IGenericRepository<Domain.Assessment.Assessment> assessmentRepository)
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

        public async Task<PagedResult<Domain.Assessment.Assessment>> GetAll(int page, int? pageSize)
        {
            return await _assessmentRepository.GetPagedList(page, pageSize);
        }

        public async Task<Domain.Assessment.Assessment> GetById(int id)
        {
            return await _assessmentRepository.FindAsync(x=>x.Id == id);
        }

        public async Task<SaveResponseDto> Insert(Domain.Assessment.Assessment entity)
        {
            var id = _assessmentRepository.GetLast().Id;
            entity.DataId = DataIdGenerationService.GenerateDataId(id, "AM");
            var response = await _assessmentRepository.AddAsync(entity);
            return new SaveResponseDto
            {
                SavedDataId = entity.DataId,
                SavedEntityId = entity.Id,
                SaveSuccessful = response != null
            };
        }

        public async Task<SaveResponseDto> Update(Domain.Assessment.Assessment entity)
        {
            if(entity.DataId == null)
            {
                var id = _assessmentRepository.GetLast().Id;
                entity.DataId = DataIdGenerationService.GenerateDataId(id, "AM");
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
