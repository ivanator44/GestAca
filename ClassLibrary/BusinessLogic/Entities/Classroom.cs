using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Classroom
    {

        // constructores
        public Classroom()
        {
            this.TaughtCourses = new List<TaughtCourse>();
        }

        public Classroom(int maxCapacity, string name)
        : this()
        {
            this.MaxCapacity = maxCapacity;
            this.Name = name;
        }
        public bool isSuitableWithCourse(TaughtCourse tc)
        {
            bool classroomIsAvailable = true;
            if (tc.Enrollments.Count <= this.MaxCapacity)
            {
                foreach (TaughtCourse tcClassroom in this.TaughtCourses)
                {
                    classroomIsAvailable = tcClassroom.coursesAreSuitable(tc);
                    if (!classroomIsAvailable) { break; }
                }
            }
            else { classroomIsAvailable = false; }
            return classroomIsAvailable;
        }
        
    }
}
