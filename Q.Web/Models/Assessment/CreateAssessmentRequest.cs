using System;
using SFX.Web.Models.Base;

namespace SFX.Web.Models.Assessment
{
    public class CreateAssessmentRequest : BaseModel
    {
        public string Title { get; set; }
        public DateTime? AssessmentDate { get; set; }

        public int AssessmentTypeId { get; set; }

        public string Reference { get; set; }

        public int? ScopeId { get; set; }

        public bool? Published { get; set; }

        public string Scope { get; set; }

        public string Frequency { get; set; }

        public int FrequencyId { get; set; }

        public bool IsSuperseded { get; set; }

        public DateTime? PublishedDate { get; set; }

        public int? PublishedByUserId { get; set; }


        public string PublishedBy { get; set; }

        public string AssessmentType { get; set; }
    }
  
}
