using System.Collections.Generic;

namespace SFX.Domain.Assessment
{
    public class AssessmentScope : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}
