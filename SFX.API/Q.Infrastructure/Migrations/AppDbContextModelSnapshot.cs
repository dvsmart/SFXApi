﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SFX.Infrastructure.Context;

namespace SFX.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SFX.Domain.Assessment.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<DateTime?>("AssessmentDate");

                    b.Property<int?>("AssessmentScopeId");

                    b.Property<int?>("AssessmentStatusId");

                    b.Property<int?>("AssessmentTypeId");

                    b.Property<int?>("AssessorUserId");

                    b.Property<string>("DataId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsSuperseded");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int?>("PublishedBy");

                    b.Property<DateTime?>("PublishedDate");

                    b.Property<int?>("RecurrenceTypeId");

                    b.Property<string>("Reference");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentScopeId");

                    b.HasIndex("AssessmentStatusId");

                    b.HasIndex("AssessmentTypeId");

                    b.HasIndex("RecurrenceTypeId");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("SFX.Domain.Assessment.AssessmentScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AssessmentScopes");
                });

            modelBuilder.Entity("SFX.Domain.Assessment.AssessmentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AssessmentStatuses");
                });

            modelBuilder.Entity("SFX.Domain.Assessment.AssessmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AssessmentTypes");
                });

            modelBuilder.Entity("SFX.Domain.Asset.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("AssetTypeId");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ManagingAgentId");

                    b.Property<int?>("ManagingAgentPortfolioId");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int?>("PortfolioId");

                    b.Property<int?>("SubPortfolioId");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("SFX.Domain.Asset.AssetProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressLine3");

                    b.Property<int>("AssetId");

                    b.Property<string>("City");

                    b.Property<int?>("CountryId");

                    b.Property<int?>("CountyId");

                    b.Property<string>("DataId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("GrossInternalSize");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("KnownAs");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<decimal?>("NetInternalSize");

                    b.Property<short?>("NumberOfFloors");

                    b.Property<short?>("NumberOfPlantRooms");

                    b.Property<string>("Postcode");

                    b.Property<string>("PropertyReference");

                    b.Property<decimal?>("PropertySize");

                    b.Property<DateTime?>("StatusArchiveDate");

                    b.Property<DateTime?>("StatusStartDate");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("AssetProperties");
                });

            modelBuilder.Entity("SFX.Domain.Asset.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AssetTypes");

                    b.HasData(
                        new { Id = 1, AddedBy = 1, AddedDate = new DateTime(2018, 10, 18, 14, 20, 26, 64, DateTimeKind.Utc), IsActive = true, IsArchived = false, IsDeleted = false, Name = "Property" }
                    );
                });

            modelBuilder.Entity("SFX.Domain.Common.RecurrenceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("DatePart");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<short>("RecurrenceNumber");

                    b.HasKey("Id");

                    b.ToTable("RecurrenceTypes");

                    b.HasData(
                        new { Id = 1, AddedBy = 1, AddedDate = new DateTime(2018, 10, 18, 15, 20, 26, 64, DateTimeKind.Local), DatePart = "yy", IsActive = true, IsArchived = false, IsDeleted = false, Name = "Annually", RecurrenceNumber = (short)1 },
                        new { Id = 2, AddedBy = 1, AddedDate = new DateTime(2018, 10, 18, 15, 20, 26, 64, DateTimeKind.Local), DatePart = "MM", IsActive = true, IsArchived = false, IsDeleted = false, Name = "Monthly", RecurrenceNumber = (short)1 },
                        new { Id = 3, AddedBy = 1, AddedDate = new DateTime(2018, 10, 18, 15, 20, 26, 64, DateTimeKind.Local), DatePart = "dd", IsActive = true, IsArchived = false, IsDeleted = false, Name = "Daily", RecurrenceNumber = (short)1 }
                    );
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<int?>("EntityGroupId");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("TemplateName");

                    b.HasKey("Id");

                    b.HasIndex("EntityGroupId");

                    b.ToTable("CustomEntityDefinitions");
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomEntityGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CustomEntityGroups");
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomEntityInstance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("CustomEntityId");

                    b.Property<string>("DataId");

                    b.Property<DateTime?>("DueDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CustomEntityId");

                    b.ToTable("CustomEntityInstances");
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<int?>("CustomEntityId");

                    b.Property<int?>("CustomTabId");

                    b.Property<string>("DefaultValue");

                    b.Property<string>("FieldName");

                    b.Property<int>("FieldTypeId");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool?>("IsMandatory");

                    b.Property<bool?>("IsVisible");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<short?>("SortOrder");

                    b.Property<string>("ToolTip");

                    b.HasKey("Id");

                    b.HasIndex("CustomEntityId");

                    b.HasIndex("CustomTabId");

                    b.HasIndex("FieldTypeId");

                    b.ToTable("CustomFields");
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomFieldType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("CustomFieldTypes");

                    b.HasData(
                        new { Id = 1, Caption = "Text Box", Type = "text" },
                        new { Id = 2, Caption = "Calender", Type = "date" },
                        new { Id = 3, Caption = "Time", Type = "time" },
                        new { Id = 4, Caption = "Text Area", Type = "textarea" },
                        new { Id = 5, Caption = "Currency Input", Type = "currency" },
                        new { Id = 6, Caption = "Checkbox", Type = "checkbox" },
                        new { Id = 7, Caption = "Select / List", Type = "select" },
                        new { Id = 8, Caption = "Numerical Input", Type = "numerical" },
                        new { Id = 9, Caption = "Percentage Input", Type = "percent" },
                        new { Id = 10, Caption = "Image Upload", Type = "image" },
                        new { Id = 11, Caption = "EmailAddress Input", Type = "email" },
                        new { Id = 12, Caption = "RichTextBox", Type = "richtextarea" }
                    );
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomFieldValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("CustomEntityRecordId");

                    b.Property<int>("CustomFieldId");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CustomEntityRecordId");

                    b.HasIndex("CustomFieldId");

                    b.ToTable("CustomFieldValues");
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomTab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("CustomEntityId");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsVisible");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<short?>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("CustomEntityId");

                    b.ToTable("CustomTabs");
                });

            modelBuilder.Entity("SFX.Domain.Event.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("AllDayEvent");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("DueDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsCompleted");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Location");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int?>("RecurrenceTypeId");

                    b.Property<DateTime?>("StartDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("RecurrenceTypeId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SFX.Domain.Menu.MenuGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsVisible");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MenuGroups");

                    b.HasData(
                        new { Id = 1, AddedBy = 1, AddedDate = new DateTime(2018, 10, 18, 14, 20, 26, 64, DateTimeKind.Utc), IsArchived = false, IsDeleted = false, IsVisible = true, Name = "group" },
                        new { Id = 2, AddedBy = 1, AddedDate = new DateTime(2018, 10, 18, 14, 20, 26, 64, DateTimeKind.Utc), IsArchived = false, IsDeleted = false, IsVisible = true, Name = "item" },
                        new { Id = 3, AddedBy = 1, AddedDate = new DateTime(2018, 10, 18, 14, 20, 26, 64, DateTimeKind.Utc), IsArchived = false, IsDeleted = false, IsVisible = true, Name = "collapsable" }
                    );
                });

            modelBuilder.Entity("SFX.Domain.Menu.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Classess");

                    b.Property<bool?>("ExactMatch");

                    b.Property<string>("ExternalUrl");

                    b.Property<bool>("HasChildren");

                    b.Property<string>("Icon");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsVisible");

                    b.Property<int>("MenuGroupId");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool?>("OpenInNewTab");

                    b.Property<int?>("ParentId");

                    b.Property<string>("Route");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Title");

                    b.Property<string>("Translate");

                    b.HasKey("Id");

                    b.HasIndex("MenuGroupId");

                    b.HasIndex("ParentId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("SFX.Domain.Task.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<int?>("CompletedBy");

                    b.Property<string>("DataId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("DueDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("RecurrenceTypeId");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("TaskPriorityId");

                    b.Property<int>("TaskStatusId");

                    b.HasKey("Id");

                    b.HasIndex("RecurrenceTypeId");

                    b.HasIndex("TaskPriorityId");

                    b.HasIndex("TaskStatusId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("SFX.Domain.Task.TaskComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Comments");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int>("TaskId");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskComments");
                });

            modelBuilder.Entity("SFX.Domain.Task.TaskPriority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TaskPriorities");
                });

            modelBuilder.Entity("SFX.Domain.Task.TaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool?>("IsActive");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TaskStatuses");
                });

            modelBuilder.Entity("SFX.Domain.User.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("EmailAddress");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserName");

                    b.Property<int>("UserRoleId");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SFX.Domain.User.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int>("PreferredLanguage");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("SFX.Domain.User.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new { Id = 1, AddedBy = 1, AddedDate = new DateTime(2018, 10, 18, 14, 20, 26, 65, DateTimeKind.Utc), IsArchived = false, IsDeleted = false, RoleName = "admin" }
                    );
                });

            modelBuilder.Entity("SFX.Domain.Assessment.Assessment", b =>
                {
                    b.HasOne("SFX.Domain.Assessment.AssessmentScope", "AssessmentScope")
                        .WithMany("Assessments")
                        .HasForeignKey("AssessmentScopeId");

                    b.HasOne("SFX.Domain.Assessment.AssessmentStatus")
                        .WithMany("Assessments")
                        .HasForeignKey("AssessmentStatusId");

                    b.HasOne("SFX.Domain.Assessment.AssessmentType", "AssessmentType")
                        .WithMany("Assessments")
                        .HasForeignKey("AssessmentTypeId");

                    b.HasOne("SFX.Domain.Common.RecurrenceType", "RecurrenceType")
                        .WithMany("Assessments")
                        .HasForeignKey("RecurrenceTypeId");
                });

            modelBuilder.Entity("SFX.Domain.Asset.Asset", b =>
                {
                    b.HasOne("SFX.Domain.Asset.AssetType", "AssetType")
                        .WithMany()
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFX.Domain.Asset.AssetProperty", b =>
                {
                    b.HasOne("SFX.Domain.Asset.Asset", "Asset")
                        .WithMany("AssetProperties")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomEntity", b =>
                {
                    b.HasOne("SFX.Domain.CustomEntity.CustomEntityGroup", "EntityGroup")
                        .WithMany("CustomEntities")
                        .HasForeignKey("EntityGroupId");
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomEntityInstance", b =>
                {
                    b.HasOne("SFX.Domain.CustomEntity.CustomEntity", "CustomEntity")
                        .WithMany("CustomEntityInstances")
                        .HasForeignKey("CustomEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomField", b =>
                {
                    b.HasOne("SFX.Domain.CustomEntity.CustomEntity", "CustomEntity")
                        .WithMany("CustomFields")
                        .HasForeignKey("CustomEntityId");

                    b.HasOne("SFX.Domain.CustomEntity.CustomTab", "CustomTab")
                        .WithMany("CustomFields")
                        .HasForeignKey("CustomTabId");

                    b.HasOne("SFX.Domain.CustomEntity.CustomFieldType", "FieldType")
                        .WithMany("CustomFields")
                        .HasForeignKey("FieldTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomFieldValue", b =>
                {
                    b.HasOne("SFX.Domain.CustomEntity.CustomEntityInstance", "CustomEntityRecord")
                        .WithMany("CustomFieldValues")
                        .HasForeignKey("CustomEntityRecordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SFX.Domain.CustomEntity.CustomField", "CustomField")
                        .WithMany()
                        .HasForeignKey("CustomFieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFX.Domain.CustomEntity.CustomTab", b =>
                {
                    b.HasOne("SFX.Domain.CustomEntity.CustomEntity", "CustomEntity")
                        .WithMany("CustomTabs")
                        .HasForeignKey("CustomEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFX.Domain.Event.Event", b =>
                {
                    b.HasOne("SFX.Domain.Common.RecurrenceType", "RecurrenceType")
                        .WithMany("Events")
                        .HasForeignKey("RecurrenceTypeId");
                });

            modelBuilder.Entity("SFX.Domain.Menu.MenuItem", b =>
                {
                    b.HasOne("SFX.Domain.Menu.MenuGroup", "MenuGroup")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SFX.Domain.Menu.MenuItem", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SFX.Domain.Task.Task", b =>
                {
                    b.HasOne("SFX.Domain.Common.RecurrenceType", "RecurrenceType")
                        .WithMany("Tasks")
                        .HasForeignKey("RecurrenceTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SFX.Domain.Task.TaskPriority", "TaskPriority")
                        .WithMany("Tasks")
                        .HasForeignKey("TaskPriorityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SFX.Domain.Task.TaskStatus", "TaskStatus")
                        .WithMany("Tasks")
                        .HasForeignKey("TaskStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFX.Domain.Task.TaskComment", b =>
                {
                    b.HasOne("SFX.Domain.Task.Task", "Task")
                        .WithMany("TaskComments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFX.Domain.User.User", b =>
                {
                    b.HasOne("SFX.Domain.User.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFX.Domain.User.UserProfile", b =>
                {
                    b.HasOne("SFX.Domain.User.User")
                        .WithOne("UserProfile")
                        .HasForeignKey("SFX.Domain.User.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
