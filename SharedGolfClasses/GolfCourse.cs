﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedGolfClasses
{
    // Golf Course API Key 'Authorization: Key 7VPX35OLKAFO2LNSUTHGCKNF3I'
    public partial class GolfCourse : ObservableObject
    {
        [Key]
        public int CourseId { get; set; }
        public string? ClubName { get; set; }
        public string? CourseName { get; set; } 
        public Tees Tees { get; set; }



    }
}
