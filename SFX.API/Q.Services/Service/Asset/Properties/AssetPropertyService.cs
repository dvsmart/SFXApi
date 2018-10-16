using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFX.Domain;
using SFX.Domain.Asset;
using SFX.Domain.Response;
using SFX.Services.Helper;
using SFX.Services.Interfaces.Asset.Properties;

namespace SFX.Services.Service.Asset.Properties
{
    public class AssetPropertyService : IAssetPropertyService
    {
        private readonly IGenericRepository<AssetProperty> _assetPropertyRepository;
        private readonly IGenericRepository<Domain.Asset.Asset> _assetRepository;

        public AssetPropertyService(IGenericRepository<AssetProperty> assetPropertyRepository, IGenericRepository<Domain.Asset.Asset> assetRepository)
        {
            _assetRepository = assetRepository;
            _assetPropertyRepository = assetPropertyRepository;
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            var property = await _assetPropertyRepository.FindAsync(x=>x.Id == id);
            await _assetPropertyRepository.DeleteAsync(property);
        }

        public async System.Threading.Tasks.Task DeleteAll(List<int> ids)
        {
            var properties = await _assetPropertyRepository.FindAllAsync(x => ids.Contains(x.Id));
            await _assetPropertyRepository.DeleteAllAsync(properties.ToList());
        }

        public async Task<PagedResult<AssetProperty>> GetAll(int page, int? pageSize)
        {
            return await _assetPropertyRepository.GetPagedList(page, pageSize);
        }

        public async Task<AssetProperty> GetById(int id)
        {
            return await _assetPropertyRepository.FindAsync(x => x.Id == id);
        }

        public async Task<SaveResponseDto> Insert(AssetProperty entity)
        {
            var asset = new Domain.Asset.Asset
            {
                AssetTypeId = 1,
                AddedBy = 1,
                AddedDate = DateTime.UtcNow,
                IsArchived = false,
                IsDeleted = false,
                ManagingAgentId = 1,
                ManagingAgentPortfolioId = 2,
                SubPortfolioId = null,
                PortfolioId = null,
            };
            
            var assetSavedResponse = await _assetRepository.AddAsync(asset);
            if (assetSavedResponse == null)
                return new SaveResponseDto
                {
                    SaveSuccessful = false,
                    ErrorMessage = "Failed adding new property."
                };
            entity.AssetId = asset.Id;
            var id = await _assetPropertyRepository.GetLast();
            entity.DataId = DataIdGenerationService.GenerateDataId(id, "AR");
            var propertySavedResponse = await _assetPropertyRepository.AddAsync(entity);
            return new SaveResponseDto
            {
                SavedDataId = entity.DataId,
                SavedEntityId = entity.AssetId,
                RecordId = entity.Id,
                SaveSuccessful = propertySavedResponse != null,
            };
        }

        public async Task<SaveResponseDto> Update(AssetProperty entity)
        {
            if (entity.DataId == null)
            {
                var id = _assetPropertyRepository.GetLast().Id;
                entity.DataId = DataIdGenerationService.GenerateDataId(id, "AR");
            }
            var response = await _assetPropertyRepository.UpdateAsync(entity, entity.Id);
            return new SaveResponseDto
            {
                SavedDataId = entity.DataId,
                SavedEntityId = entity.AssetId,
                SaveSuccessful = response != null,
                ErrorMessage = response == null ? string.Empty : "update failed"
            };
        }
    }
}
