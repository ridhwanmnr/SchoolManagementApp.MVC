using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class ClassMetaData
{  
    [Display(Name="Lecturer")]
    public int? LecturerId { get; set; }

    [Display(Name="Course")]
    public int? CourseId { get; set; }

    [Required]
    [Display(Name="Time")]
    public TimeSpan? Time { get; set; }
}

[ModelMetadataType(typeof(ClassMetaData))]
public partial class Class{}