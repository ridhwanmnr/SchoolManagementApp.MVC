using System;
using System.Collections.Generic;

namespace SchoolManagementApp.MVC.Data
{
    public partial class Lecturer
    {
        public Lecturer()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}
