using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class CourseMetaData
{
    [Required]
    [StringLength(100)]
    [Display(Name="Name")]
    public string Name { get; set; } = null!;
    
    [Required]
    [Display(Name="Course Code")]
    public string? Code { get; set; }
    public int? Credits { get; set; }
}

[ModelMetadataType(typeof(CourseMetaData))]
public partial class Course{}