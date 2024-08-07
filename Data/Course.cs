using System;
using System.Collections.Generic;

namespace SchoolManagementApp.MVC.Data
{
    public partial class Course
    {
        public Course()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public int? Credits { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
