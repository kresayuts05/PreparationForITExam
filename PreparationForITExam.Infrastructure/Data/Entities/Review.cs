﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Review
    {
        public Review()
        {
            IsActive= true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0, 5)]
        public int Stars { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
