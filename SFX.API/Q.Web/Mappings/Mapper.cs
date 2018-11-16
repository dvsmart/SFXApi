using System;
using System.Collections.Generic;
using System.Linq;
 
using SFX.Core.Domain.Event;
using SFX.Core.Domain.Menu;
using SFX.Web.Models.Assessment;
using SFX.Web.Models.CustomEntity;
using SFX.Web.Models.Event;
using SFX.Web.Models.Menu;

namespace SFX.Web.Mappings
{
    public static class Mapper
    {
        public static Core.Domain.Assessment.Assessment MapToAssessmentDto(CreateAssessmentRequest assessmentRequestModel)
        {
            var assessmentDto = new Core.Domain.Assessment.Assessment
            {
                AssessmentDate = assessmentRequestModel.AssessmentDate,
                RecurrenceTypeId = assessmentRequestModel.FrequencyId,
                AssessmentScopeId = assessmentRequestModel.ScopeId,
                AssessmentTypeId = assessmentRequestModel.AssessmentTypeId,
                Reference = assessmentRequestModel.Reference,
                Title = assessmentRequestModel.Title,
                PublishedDate = assessmentRequestModel.PublishedDate,
                PublishedBy = assessmentRequestModel.PublishedByUserId,
                IsArchived = false,
                IsDeleted = false,
                IsSuperseded = false,
                AssessorUserId = 1,
                Id = assessmentRequestModel.Id,
                DataId = assessmentRequestModel.DataId
            };
            if (assessmentDto.Id == default(int))
            {
                assessmentDto.AddedDate = DateTime.UtcNow;
                assessmentDto.AddedBy = 1;
            }
            else
            {
                assessmentDto.ModifiedBy = 1;
                assessmentDto.ModifiedDate = DateTime.UtcNow;
            }
            return assessmentDto;
        }

        public static CreateAssessmentRequest MapToAssessmentModel(Core.Domain.Assessment.Assessment assessmentDto)
        {
            return new CreateAssessmentRequest
            {
                AssessmentDate = assessmentDto.AssessmentDate,
                FrequencyId = assessmentDto.RecurrenceTypeId ?? 0,
                ScopeId = assessmentDto.AssessmentScopeId,
                AssessmentTypeId = assessmentDto.AssessmentTypeId ?? 0,
                Reference = assessmentDto.Reference,
                Title = assessmentDto.Title,
                PublishedDate = assessmentDto.PublishedDate,
                PublishedByUserId = assessmentDto.PublishedBy ?? default(int),
                ModifiedDate = DateTime.UtcNow,
                IsSuperseded = false,
                DataId = assessmentDto.DataId,
                Published = assessmentDto.PublishedBy.HasValue && assessmentDto.PublishedDate.HasValue,
                Id = assessmentDto.Id
            };
        }

        public static EventModel MapToEventModel(Core.Domain.Event.Event eventDto)
        {
            return new EventModel
            {
                AllDayEvent = eventDto.AllDayEvent,
                Description = eventDto.Description,
                End = eventDto.DueDate,
                Start = eventDto.StartDate,
                IsCompleted = eventDto.IsCompleted,
                RecurrenceType = eventDto.RecurrenceType.Name,
                Id = eventDto.Id,
                Title = eventDto.Title,
                AddedDate = eventDto.AddedDate,
            };
        }

        public static Event MapToEventDto(EventModel eventModel)
        {
            return new Event
            {
                AllDayEvent = eventModel.AllDayEvent,
                Description = eventModel.Description,
                DueDate = eventModel.End,
                StartDate = eventModel.Start,
                IsCompleted = eventModel.IsCompleted,
                RecurrenceTypeId = eventModel.RecurrenceTypeId,
                Id = eventModel.Id,
                Title = eventModel.Title,
                AddedDate = DateTime.UtcNow,
                AddedBy = 1,
                Location = eventModel.Location,
                ModifiedBy = eventModel.Id == default(int) ? (int?)null : 1,
                ModifiedDate = eventModel.Id == default(int) ? (DateTime?)null : DateTime.UtcNow,
            };
        }


        public static Core.Domain.CustomEntity.CustomEntityGroup MapToTemplateGroup(CustomEntityGroupModel customEntityGroupModel)
        {
            return new Core.Domain.CustomEntity.CustomEntityGroup
            {
                Name = customEntityGroupModel.CategoryName,
                AddedBy = 1,
                AddedDate = DateTime.UtcNow,
                Id = customEntityGroupModel.Id,
                IsArchived = false,
                IsDeleted = false
            };
        }

        //public static Core.Domain.CustomEntity.CustomEntity MapToCustomEntityDto(CreateCustomTemplateRequest createCustomTemplateRequest)
        //{
        //    return new Core.Domain.CustomEntity.CustomEntity
        //    {
        //        TemplateName = createCustomTemplateRequest.TemplateName,
        //        AddedBy = 1,
        //        AddedDate = DateTime.UtcNow,
        //        Id = createCustomTemplateRequest.Id,
        //        IsArchived = false,
        //        IsDeleted = false,
        //        EntityGroupId = createCustomTemplateRequest.GroupId
        //    };
        //}

        //public static CustomEntityGroupModel MapToCustomEntityGroupModel(Core.Domain.CustomEntity.CustomEntityGroup groupDto)
        //{
        //    return new CustomEntityGroupModel
        //    {
        //        CategoryName = groupDto.Name,
        //        Id = groupDto.Id
        //    };
        //}

        //public static CustomEntityTemplateModel MapToCustomEntityTemplateModel(Core.Domain.CustomEntity.CustomEntity templateDto)
        //{
        //    return new CustomEntityTemplateModel
        //    {
        //        TemplateName = templateDto.TemplateName,
        //        Id = templateDto.Id,
        //    };
        //}

        //public static List<CustomEntityGroupModel> MapToCustomEntityGroups(IEnumerable<Core.Domain.CustomEntity.CustomEntityGroup> groups)
        //{
        //    if (groups == null) return new List<CustomEntityGroupModel>();

        //    return groups.Select(x => new CustomEntityGroupModel
        //    {
        //        CategoryName = x.Name,
        //        Id = x.Id
        //    }).ToList();
        //}

        //public static CustomTemplateModel MapToCustomTemplates(Core.Domain.CustomEntity.CustomEntityGroup group)
        //{
        //    if (group == null) return new CustomTemplateModel();

        //    return new CustomTemplateModel
        //    {
        //        GroupId = group.Id,
        //        GroupName = group.Name,
        //        Templates = group.CustomEntities.Select(x => new CustomEntityTemplateModel
        //        {
        //            TemplateName = x.TemplateName,
        //            Id = x.Id,
        //        }).ToList()
        //    };
        //}

        //public static List<CustomEntityTemplateModel> MaptoCustomTemplates(IEnumerable<Core.Domain.CustomEntity.CustomEntity> templates)
        //{
        //    return templates.Select(x => new CustomEntityTemplateModel
        //    {
        //        Id = x.Id,
        //        TemplateName = x.TemplateName,
        //    }).ToList();
        //}


        public static List<CustomEntityInstanceGridModel> MapToCustomEntityValueGridModel(IList<Core.Domain.CustomEntity.CustomEntityInstance> customEntityInstances)
        {
            var recordModel = new List<CustomEntityInstanceGridModel>();
            if (customEntityInstances == null) return recordModel;
            recordModel.AddRange(customEntityInstances.Select(item => new CustomEntityInstanceGridModel
            {
                Id = item.Id,
                AddedOn = item.AddedDate,
                DataId = item.DataId,
                DueDate = item.DueDate ?? DateTime.UtcNow.AddDays(5),
                Status = item.Status == 1 ? "Draft" : "Published"
            }));
            return recordModel;
        }

        public static List<MenuModel> GetMenuItems(ICollection<MenuItem> menuItems, bool? isChild)
        {
            var menuItemList = menuItems.Where(item => item.ParentId == null || (isChild.HasValue && isChild.Value))
                              .Select(item => new MenuModel
                              {
                                  Title = item.Title,
                                  Type = item.MenuGroup.Name,
                                  Url = item.Route,
                                  Icon = item.Icon,
                                  HasChildren = item.HasChildren,
                                  IsVisible = item.IsVisible,
                                  MenuGroupId = item.MenuGroupId,
                                  ParentId = item.ParentId,
                                  Id = item.Id,
                                  OpenInNewTab = item.OpenInNewTab,
                                  ExternalUrl = item.ExternalUrl,
                                  Children = item.HasChildren ? GetMenuItems(item.Children, true) : null
                              }).ToList();

            return menuItemList.OrderBy(x => x.SortOrder).ToList();
        }

        public static List<EventModel> MapEvents(PagedResult<Event> events)
        {
            return events.Results?.Select(x => new EventModel
            {
                Id = x.Id,
                End = x.DueDate,
                Start = x.StartDate,
                AddedDate = x.AddedDate,
                AllDayEvent = x.AllDayEvent,
                Description = x.Description,
                IsCompleted = x.IsCompleted,
                Location = x.Location,
                RecurrenceTypeId = x.RecurrenceTypeId,
                Title = x.Title
            }).ToList();
        }
    }
}
