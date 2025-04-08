using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Teacher
    {
        // constructoress
        public Teacher()
        {
            this.TaughtCourses = new List<TaughtCourse>();
        }

        public Teacher(string address, string id, string name, int zipCode, string ssn)
        : base(address, id, name, zipCode)
        {
            this.Ssn = ssn;
            this.TaughtCourses = new List<TaughtCourse>();
        }

        public bool isSuitableWithCourse(TaughtCourse tc)
        {
            bool teacherIsAvailable = true;
            foreach (TaughtCourse tcTeacher in this.TaughtCourses) {
                teacherIsAvailable = tcTeacher.coursesAreSuitable(tc);
                if (!teacherIsAvailable) { break; }
            }
            return teacherIsAvailable;
        }

    }
}
