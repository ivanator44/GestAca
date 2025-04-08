using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Course
    {
        // constructores
        public Course()
        {
            this.TaughtCourses = new List<TaughtCourse>();
        }

        public Course(string description, string name)
        : this()
        {
            this.Description = description;
            this.Name = name;
        }

    }
}
