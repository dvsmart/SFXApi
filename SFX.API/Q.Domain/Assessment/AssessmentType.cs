using System.Collections.Generic;

namespace SFX.Domain.Assessment
{
    public class AssessmentType : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}
