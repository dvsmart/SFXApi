using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SFX.Domain;
using SFX.Domain.Assessment;
using SFX.Domain.Asset;
using SFX.Domain.Common;
using SFX.Domain.CustomEntity;
using SFX.Domain.Event;
using SFX.Domain.Menu;
using SFX.Domain.Task;
using SFX.Domain.User;
using SFX.Infrastructure;
using SFX.Infrastructure.IRepositories;
using SFX.Infrastructure.Mappings;
using SFX.Infrastructure.Repositories;
using SFX.Services.Interfaces.Assessment;
using SFX.Services.Interfaces.Asset.Properties;
using SFX.Services.Interfaces.Authentication;
using SFX.Services.Interfaces.CustomEntity;
using SFX.Services.Interfaces.Event;
using SFX.Services.Interfaces.Menu;
using SFX.Services.Interfaces.Settings.CustomEntityManagement;
using SFX.Services.Interfaces.Task;
using SFX.Services.Interfaces.User;
using SFX.Services.Service.Assessment;
using SFX.Services.Service.Asset.Properties;
using SFX.Services.Service.Authentication;
using SFX.Services.Service.CustomEntity;
using SFX.Services.Service.Event;
using SFX.Services.Service.Menu;
using SFX.Services.Service.Settings.CustomEntityManagement;
using SFX.Services.Service.Task;
using SFX.Services.Service.User;
using SFX.Web.Controllers.Asset;
using SFX.Web.Mappings;

namespace SFX.Web.Modules
{
    public static class InjectionModule 
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();

            //Repository
            services.AddTransient<IGenericRepository<AssessmentScope>, GenericRepository<AssessmentScope>>();
            services.AddTransient<IGenericRepository<Assessment>, GenericRepository<Assessment>>();
            services.AddTransient<IGenericRepository<AssessmentStatus>, GenericRepository<AssessmentStatus>>();
            services.AddTransient<IGenericRepository<AssessmentType>, GenericRepository<AssessmentType>>();
            services.AddTransient<IGenericRepository<AssetProperty>, GenericRepository<AssetProperty>>();
            services.AddTransient<IGenericRepository<Asset>, GenericRepository<Asset>>();
            services.AddTransient<IGenericRepository<CustomFieldType>, GenericRepository<CustomFieldType>>();
            services.AddTransient<IGenericRepository<CustomEntityGroup>, GenericRepository<CustomEntityGroup>>();
            services.AddTransient<IGenericRepository<CustomField>, GenericRepository<CustomField>>();
            services.AddTransient<IGenericRepository<CustomEntityInstance>, GenericRepository<CustomEntityInstance>>();
            services.AddTransient<IGenericRepository<CustomEntity>, GenericRepository<CustomEntity>>();
            services.AddTransient<IGenericRepository<CustomFieldValue>, GenericRepository<CustomFieldValue>>();
            services.AddTransient<IGenericRepository<CustomEntityGroup>, GenericRepository<CustomEntityGroup>>();
            services.AddTransient<IGenericRepository<CustomTab>, GenericRepository<CustomTab>>();
            services.AddTransient<IGenericRepository<Event>, GenericRepository<Event>>();
            services.AddTransient<IGenericRepository<MenuItem>, GenericRepository<MenuItem>>();
            services.AddTransient<IGenericRepository<MenuGroup>, GenericRepository<MenuGroup>>();
            services.AddTransient<IGenericRepository<RecurrenceType>, GenericRepository<RecurrenceType>>();
            services.AddTransient<IGenericRepository<TaskPriority>, GenericRepository<TaskPriority>>();
            services.AddTransient<IGenericRepository<Task>, GenericRepository<Task>>();
            services.AddTransient<IGenericRepository<TaskStatus>, GenericRepository<TaskStatus>>();
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
            services.AddTransient<IGenericRepository<UserRole>, GenericRepository<UserRole>>();
            services.AddTransient<IFormRecordRepository, FormRecordRepository>();

            //Services
            services.AddTransient<IOutputConverter, OutputConverter>();
            services.AddTransient<IAssessmentScopeService, AssessmentScopeService>();
            services.AddTransient<IAssessmentService, AssessmentService>();
            services.AddTransient<IAssessmentStatusService, AssessmentStatusService>();
            services.AddTransient<IAssessmentTypeService, AssessmentTypeService>();
            services.AddTransient<IAssetPropertyService, AssetPropertyService>();
            services.AddTransient<IFormControlTypeService, FormControlTypeService>();
            services.AddTransient<ITemplateCategoryService, TemplateCategoryService>();
            services.AddTransient<ITemplateFormControlService, TemplateFormControlService>();
            services.AddTransient<ITemplateFormRecordService, TemplateFormRecordService>();
            services.AddTransient<ITemplateFormValueService, TemplateFormValueService>();
            services.AddTransient<ITemplateService, TemplateService>();
            services.AddTransient<ITemplateTabService, TemplateTabService>();
            services.AddTransient<IEventService, EventService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<ICustomEntityManagementService, CustomEntityManagementService>();
            services.AddTransient<ICustomTemplateService, CustomTemplateService>();
            services.AddTransient<ITaskPriorityService, TaskPriorityService>();
            services.AddTransient<ITaskService, TaskService>();
            services.AddTransient<ITaskStatusService, TaskStatusService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IFormRecordService, FormRecordService>();

            //API
            services.AddTransient<IPresenter, Presenter>();

        }
    }
}
