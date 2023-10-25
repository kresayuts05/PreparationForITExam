﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Image
    {
        public Image()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string UrlPath { get; set; }

        [Required]
        public bool IsActive { get; set; }

        //[ForeignKey(nameof(Post))]
        //public int PostId { get; set; }
        //public Post Post { get; set; }
    }
}
