using System;

namespace SFX.Core.Domain.Risk
{
    public class Risk : BaseEntity
    {
        public int? RiskAssessmentTypeId { get; set; }
        public int? RiskDescriptionId { get; set; }
        public string Guidance { get; set; }
        public string RelatedLegislation { get; set; }
        public int? LocationId { get; set; }
        public DateTime? IdentifiedOn { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int RiskTypeId { get; set; } 
        public int? HazardId { get; set; }
                
        public int? ControlId { get; set; }
        public string RiskDataId { get; set; }
        public int?RiskStatusId { get; set; }
        public int? RiskPriorityId { get; set; }
        public int? TopicId { get; set; }
        public short RiskRatingValue { get; set; }
        public bool? IsVaultRisk { get; set; }
        public bool? IsControlledRisk { get; set; }
        public DateTime? ControlledOn { get; set; }
        public bool? IsAssociatedAssessmentPublished { get; set; }
    }
}
