﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;
using SFX.Dtos.CustomEntity;

namespace SFX.Services.Interfaces.CustomEntity
{
    public interface IFormRecordService
    {
        Task<CustomEntityRecordDto> Get(int id);

        Task<SaveResponseDto> Add(CustomEntityInstance customEntityInstance);

        Task<CustomEntityRecordDto> GetByTemplateId(int templateId);
    }
}
