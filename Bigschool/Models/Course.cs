﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bigschool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerID { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public Category Category {get;set;}
        [Required]
        public byte CategoryId { get; set; }
    }
    
}