﻿using System.Collections.Generic;
using System.Threading.Tasks;
 
using SFX.Core.Domain.Assessment;
using SFX.Core.Interfaces.Repositories;
using SFX.Services.Interfaces.Assessment;

namespace SFX.Services.Assessment
{
    public class AssessmentStatusService : IAssessmentStatusService
    {
        private readonly IGenericRepository<AssessmentStatus> _assessmentStatusRepository;

        public AssessmentStatusService(IGenericRepository<AssessmentStatus> assessmentStatusRepository)
        {
            _assessmentStatusRepository = assessmentStatusRepository;
        }

        public async Task<IEnumerable<AssessmentStatus>> GetAssessmentStatuses()
        {
            return await _assessmentStatusRepository.GetAllAsync();
        }
      
    }
}