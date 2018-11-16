﻿using SFX.Core.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SFX.Core.Domain.User
{
    public class UserProfile : BaseEntity
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string DisplayName => FirstName + " " + LastName;

        public string Address { get; set; }

        public string City { get; set; }

        public int PreferredLanguage { get; set; } = 1;

    }
}