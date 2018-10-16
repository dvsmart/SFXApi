using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SFX.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentScopes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentScopes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomEntityGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomEntityGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomFieldTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFieldTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecurrenceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RecurrenceNumber = table.Column<short>(nullable: false),
                    DatePart = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecurrenceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskPriorities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskPriorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    PortfolioId = table.Column<int>(nullable: true),
                    SubPortfolioId = table.Column<int>(nullable: true),
                    ManagingAgentId = table.Column<int>(nullable: true),
                    ManagingAgentPortfolioId = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AssetTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_AssetTypes_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomEntityDefinitions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TemplateName = table.Column<string>(nullable: true),
                    EntityGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomEntityDefinitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomEntityDefinitions_CustomEntityGroups_EntityGroupId",
                        column: x => x.EntityGroupId,
                        principalTable: "CustomEntityGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Route = table.Column<string>(nullable: true),
                    ExactMatch = table.Column<bool>(nullable: true),
                    HasChildren = table.Column<bool>(nullable: false),
                    Classess = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Translate = table.Column<string>(nullable: true),
                    IsVisible = table.Column<bool>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    MenuGroupId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    ExternalUrl = table.Column<string>(nullable: true),
                    OpenInNewTab = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItems_MenuGroups_MenuGroupId",
                        column: x => x.MenuGroupId,
                        principalTable: "MenuGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItems_MenuItems_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DataId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    PublishedBy = table.Column<int>(nullable: true),
                    AssessmentTypeId = table.Column<int>(nullable: true),
                    AssessmentScopeId = table.Column<int>(nullable: true),
                    RecurrenceTypeId = table.Column<int>(nullable: true),
                    PublishedDate = table.Column<DateTime>(nullable: true),
                    AssessmentDate = table.Column<DateTime>(nullable: true),
                    IsSuperseded = table.Column<bool>(nullable: false),
                    AssessorUserId = table.Column<int>(nullable: true),
                    AssessmentStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessments_AssessmentScopes_AssessmentScopeId",
                        column: x => x.AssessmentScopeId,
                        principalTable: "AssessmentScopes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assessments_AssessmentStatuses_AssessmentStatusId",
                        column: x => x.AssessmentStatusId,
                        principalTable: "AssessmentStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assessments_AssessmentTypes_AssessmentTypeId",
                        column: x => x.AssessmentTypeId,
                        principalTable: "AssessmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assessments_RecurrenceTypes_RecurrenceTypeId",
                        column: x => x.RecurrenceTypeId,
                        principalTable: "RecurrenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: true),
                    RecurrenceTypeId = table.Column<int>(nullable: true),
                    AllDayEvent = table.Column<bool>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_RecurrenceTypes_RecurrenceTypeId",
                        column: x => x.RecurrenceTypeId,
                        principalTable: "RecurrenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DataId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    TaskStatusId = table.Column<int>(nullable: false),
                    TaskPriorityId = table.Column<int>(nullable: false),
                    RecurrenceTypeId = table.Column<int>(nullable: false),
                    CompletedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_RecurrenceTypes_RecurrenceTypeId",
                        column: x => x.RecurrenceTypeId,
                        principalTable: "RecurrenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskPriorities_TaskPriorityId",
                        column: x => x.TaskPriorityId,
                        principalTable: "TaskPriorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskStatuses_TaskStatusId",
                        column: x => x.TaskStatusId,
                        principalTable: "TaskStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetProperties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DataId = table.Column<string>(nullable: true),
                    AssetId = table.Column<int>(nullable: false),
                    PropertyReference = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CountyId = table.Column<int>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    KnownAs = table.Column<string>(nullable: true),
                    PropertySize = table.Column<decimal>(nullable: true),
                    NetInternalSize = table.Column<decimal>(nullable: true),
                    GrossInternalSize = table.Column<decimal>(nullable: true),
                    NumberOfFloors = table.Column<short>(nullable: true),
                    NumberOfPlantRooms = table.Column<short>(nullable: true),
                    StatusStartDate = table.Column<DateTime>(nullable: true),
                    StatusArchiveDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetProperties_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomEntityInstances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DataId = table.Column<string>(nullable: true),
                    CustomEntityId = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomEntityInstances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomEntityInstances_CustomEntityDefinitions_CustomEntityId",
                        column: x => x.CustomEntityId,
                        principalTable: "CustomEntityDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomTabs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsVisible = table.Column<bool>(nullable: false),
                    SortOrder = table.Column<short>(nullable: true),
                    CustomEntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomTabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomTabs_CustomEntityDefinitions_CustomEntityId",
                        column: x => x.CustomEntityId,
                        principalTable: "CustomEntityDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    TaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskComments_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PreferredLanguage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomFieldValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CustomFieldId = table.Column<int>(nullable: false),
                    CustomEntityRecordId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFieldValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomFieldValues_CustomEntityInstances_CustomEntityRecordId",
                        column: x => x.CustomEntityRecordId,
                        principalTable: "CustomEntityInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomFields",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    FieldName = table.Column<string>(nullable: true),
                    FieldTypeId = table.Column<int>(nullable: false),
                    CustomTabId = table.Column<int>(nullable: false),
                    IsMandatory = table.Column<bool>(nullable: true),
                    ToolTip = table.Column<string>(nullable: true),
                    DefaultValue = table.Column<string>(nullable: true),
                    SortOrder = table.Column<short>(nullable: true),
                    IsVisible = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomFields_CustomTabs_CustomTabId",
                        column: x => x.CustomTabId,
                        principalTable: "CustomTabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomFields_CustomFieldTypes_FieldTypeId",
                        column: x => x.FieldTypeId,
                        principalTable: "CustomFieldTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "AddedBy", "AddedDate", "IsActive", "IsArchived", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 1, 1, new DateTime(2018, 9, 27, 12, 42, 55, 507, DateTimeKind.Utc), true, false, false, null, null, "Property" });

            migrationBuilder.InsertData(
                table: "CustomFieldTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 13, "richtextarea" },
                    { 12, "email" },
                    { 11, "phone" },
                    { 10, "image" },
                    { 9, "percent" },
                    { 8, "numerical" },
                    { 7, "select" },
                    { 6, "checkbox" },
                    { 4, "textarea" },
                    { 3, "time" },
                    { 2, "date" },
                    { 1, "text" },
                    { 5, "currency" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "Id", "AddedBy", "AddedDate", "IsArchived", "IsDeleted", "IsVisible", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2018, 9, 27, 12, 42, 55, 507, DateTimeKind.Utc), false, false, true, null, null, "item" },
                    { 1, 1, new DateTime(2018, 9, 27, 12, 42, 55, 507, DateTimeKind.Utc), false, false, true, null, null, "group" },
                    { 3, 1, new DateTime(2018, 9, 27, 12, 42, 55, 507, DateTimeKind.Utc), false, false, true, null, null, "collapsable" }
                });

            migrationBuilder.InsertData(
                table: "RecurrenceTypes",
                columns: new[] { "Id", "AddedBy", "AddedDate", "DatePart", "IsActive", "IsArchived", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "RecurrenceNumber" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2018, 9, 27, 13, 42, 55, 507, DateTimeKind.Local), "dd", true, false, false, null, null, "Daily", (short)1 },
                    { 2, 1, new DateTime(2018, 9, 27, 13, 42, 55, 507, DateTimeKind.Local), "MM", true, false, false, null, null, "Monthly", (short)1 },
                    { 1, 1, new DateTime(2018, 9, 27, 13, 42, 55, 507, DateTimeKind.Local), "yy", true, false, false, null, null, "Annually", (short)1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_AssessmentScopeId",
                table: "Assessments",
                column: "AssessmentScopeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_AssessmentStatusId",
                table: "Assessments",
                column: "AssessmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_AssessmentTypeId",
                table: "Assessments",
                column: "AssessmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_RecurrenceTypeId",
                table: "Assessments",
                column: "RecurrenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetProperties_AssetId",
                table: "AssetProperties",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetTypeId",
                table: "Assets",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomEntityDefinitions_EntityGroupId",
                table: "CustomEntityDefinitions",
                column: "EntityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomEntityInstances_CustomEntityId",
                table: "CustomEntityInstances",
                column: "CustomEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomFields_CustomTabId",
                table: "CustomFields",
                column: "CustomTabId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomFields_FieldTypeId",
                table: "CustomFields",
                column: "FieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomFieldValues_CustomEntityRecordId",
                table: "CustomFieldValues",
                column: "CustomEntityRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomTabs_CustomEntityId",
                table: "CustomTabs",
                column: "CustomEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_RecurrenceTypeId",
                table: "Events",
                column: "RecurrenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuGroupId",
                table: "MenuItems",
                column: "MenuGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_ParentId",
                table: "MenuItems",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskComments_TaskId",
                table: "TaskComments",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_RecurrenceTypeId",
                table: "Tasks",
                column: "RecurrenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskPriorityId",
                table: "Tasks",
                column: "TaskPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskStatusId",
                table: "Tasks",
                column: "TaskStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserId",
                table: "UserProfile",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleId",
                table: "Users",
                column: "UserRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "AssetProperties");

            migrationBuilder.DropTable(
                name: "CustomFields");

            migrationBuilder.DropTable(
                name: "CustomFieldValues");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "TaskComments");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "AssessmentScopes");

            migrationBuilder.DropTable(
                name: "AssessmentStatuses");

            migrationBuilder.DropTable(
                name: "AssessmentTypes");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "CustomTabs");

            migrationBuilder.DropTable(
                name: "CustomFieldTypes");

            migrationBuilder.DropTable(
                name: "CustomEntityInstances");

            migrationBuilder.DropTable(
                name: "MenuGroups");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AssetTypes");

            migrationBuilder.DropTable(
                name: "CustomEntityDefinitions");

            migrationBuilder.DropTable(
                name: "RecurrenceTypes");

            migrationBuilder.DropTable(
                name: "TaskPriorities");

            migrationBuilder.DropTable(
                name: "TaskStatuses");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "CustomEntityGroups");
        }
    }
}
