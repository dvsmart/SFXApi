using SFX.Core.Interfaces;
using System.Collections.Generic;

namespace SFX.Core.Domain.Assessment
{
    public class AssessmentStatus : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}
