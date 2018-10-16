using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SFX.Domain.Assessment;
using SFX.Domain.Asset;
using SFX.Domain.Common;
using SFX.Domain.CustomEntity;
using SFX.Domain.Event;
using SFX.Domain.Menu;
using SFX.Domain.Task;
using SFX.Domain.User;
using UserRole = SFX.Domain.User.UserRole;

namespace SFX.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        #region  == Assets ==

        public DbSet<Asset> Assets { get; set; }

        public DbSet<AssetType> AssetTypes { get; set; }

        public DbSet<AssetProperty> AssetProperties { get; set; }

        #endregion

        #region == Assessments ==
        public DbSet<Assessment> Assessments { get; set; }

        public DbSet<AssessmentScope> AssessmentScopes { get; set; }

        public DbSet<AssessmentStatus> AssessmentStatuses { get; set; }

        public DbSet<AssessmentType> AssessmentTypes { get; set; }
        #endregion

        #region == Tasks ==
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskStatus> TaskStatuses { get; set; }

        public DbSet<TaskPriority> TaskPriorities { get; set; }

        public DbSet<TaskComment> TaskComments { get; set; }
        #endregion

        #region == Users ==
        public DbSet<User> Users { get; set; }

        public DbSet<UserProfile> UserProfile { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        #region == Menu ==
        public DbSet<MenuGroup> MenuGroups { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }
        #endregion

        #region == Custom Entity Groups ==
        public DbSet<CustomEntityGroup> CustomEntityGroups { get; set; }
        #endregion

        #region == Custom Entities ==
        public DbSet<CustomEntity> CustomEntityDefinitions { get; set; }

        public DbSet<CustomTab> CustomTabs { get; set; }

        public DbSet<CustomField> CustomFields { get; set; }

        public DbSet<CustomFieldType> CustomFieldTypes { get; set; }

        public DbSet<CustomFieldValue> CustomFieldValues { get; set; }
        #endregion

        #region == Custom Entity Instances ==

        public DbSet<CustomEntityInstance> CustomEntityInstances { get; set; }

        #endregion

        #region == Common ==
        public DbSet<RecurrenceType> RecurrenceTypes { get; set; }
        #endregion

        #region == Event ==

        public DbSet<Event> Events { get; set; }



        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomFieldType>().HasData(
                    new CustomFieldType
                    {
                        Id = 1,
                        Type = "text",
                        Caption = "Text Box"
                    },
                    new CustomFieldType
                    {
                        Id = 2,
                        Type = "date",
                        Caption = "Calender"
                    },
                    new CustomFieldType
                    {
                        Id = 3,
                        Type = "time",
                        Caption = "Time"
                    },
                    new CustomFieldType
                    {
                        Id = 4,
                        Type = "textarea",
                        Caption = "Text Area"
                    },
                    new CustomFieldType
                    {
                        Id = 5,
                        Type = "currency",
                        Caption = "Currency Input"
                    },
                    new CustomFieldType
                    {
                        Id = 6,
                        Type = "checkbox",
                        Caption = "Checkbox"
                    },
                    new CustomFieldType
                    {
                        Id = 7,
                        Type = "select",
                        Caption = "Select / List"
                    },
                    new CustomFieldType
                    {
                        Id = 8,
                        Type = "numerical",
                        Caption = "Numerical Input"
                    },
                    new CustomFieldType
                    {
                        Id = 9,
                        Type = "percent",
                        Caption = "Percentage Input"
                    },
                    new CustomFieldType
                    {
                        Id = 10,
                        Type = "image",
                        Caption = "Image Upload"
                    },
                    new CustomFieldType
                    {
                        Id = 11,
                        Type = "email",
                        Caption = "EmailAddress Input"
                    },
                    new CustomFieldType
                    {
                        Id = 12,
                        Type = "richtextarea",
                        Caption = "RichTextBox"
                    }
                   );


            modelBuilder.Entity<AssetProperty>().Property(p => p.DataId).ValueGeneratedOnAdd();

            modelBuilder.Entity<Assessment>().Property(p => p.DataId).ValueGeneratedOnAdd();

            modelBuilder.Entity<RecurrenceType>().HasData(
                new RecurrenceType
                {
                    RecurrenceNumber = 1,
                    DatePart = "yy",
                    AddedBy = 1,
                    AddedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Annually",
                    IsArchived = false,
                    IsDeleted = false,
                    Id = 1
                },
                new RecurrenceType
                {
                    RecurrenceNumber = 1,
                    DatePart = "MM",
                    AddedBy = 1,
                    AddedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Monthly",
                    IsArchived = false,
                    IsDeleted = false,
                    Id = 2
                },
                new RecurrenceType
                {
                    RecurrenceNumber = 1,
                    DatePart = "dd",
                    AddedBy = 1,
                    AddedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Daily",
                    IsArchived = false,
                    IsDeleted = false,
                    Id = 3
                });

            modelBuilder.Entity<AssetType>().HasData(
                new AssetType
                {
                    Id = 1,
                    Name = "Property",
                    AddedBy = 1,
                    AddedDate = DateTime.UtcNow,
                    IsArchived = false,
                    IsDeleted = false,
                    IsActive = true
                });

            modelBuilder.Entity<MenuGroup>().HasData(
                new MenuGroup
                {
                    Id = 1,
                    Name = "group",
                    IsVisible = true,
                    AddedBy = 1,
                    AddedDate = DateTime.UtcNow,
                }, new MenuGroup
                {
                    Id = 2,
                    Name = "item",
                    IsVisible = true,
                    AddedBy = 1,
                    AddedDate = DateTime.UtcNow,
                },
                new MenuGroup
                {
                    Id = 3,
                    Name = "collapsable",
                    IsVisible = true,
                    AddedBy = 1,
                    AddedDate = DateTime.UtcNow,
                });

            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                Id = 1,
                RoleName = "admin",
                AddedBy = 1,
                AddedDate = DateTime.UtcNow,
                IsDeleted = false,
                IsArchived = false
            });
        }
    }

    public class ContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            //DHAKSHYVIJAYLTD\SQLEXPRESS
            //AKDEV19\\SQLEXPRESS
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlServer("Server=AKDEV19\\SQLEXPRESS;Database=QPocDb;Trusted_Connection=True;MultipleActiveResultSets=true;integrated security=True;",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(AppDbContext).GetTypeInfo().Assembly.GetName().Name));
            return new AppDbContext(builder.Options);
        }
    }
}
