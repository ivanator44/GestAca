using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAca.Services;

namespace GestAca.Entities
{
    public partial class Student
    {
        // constructores
        public Student()
        {
            this.Enrollments = new List<Enrollment>();
        }

        public Student(string address, string id, string name, int zipCode, string iban)
        : base(address, id, name, zipCode)
        {
            this.IBAN = iban;
            this.Enrollments = new List<Enrollment>();
        }

        public bool isAssignedToCourse(TaughtCourse tc)
        {
            foreach (Enrollment enrollment in this.Enrollments)
            {
                if (enrollment.TaughtCourse == tc)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
