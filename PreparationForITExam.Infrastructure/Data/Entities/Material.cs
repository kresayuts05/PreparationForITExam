﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.MaterialConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Material
    {
        public Material()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string UrlPath { get; set; } = null!;

        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
