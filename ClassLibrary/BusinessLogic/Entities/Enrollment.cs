using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
	public partial class Enrollment
	{
		// constructores
		public Enrollment()
		{
			this.Absences = new List<Absence>();
		}

		public Enrollment(DateTime enrollmentDate, bool uniquePayment, Student student, TaughtCourse taughtCourse)
		: this()
		{
			this.CancellationDate = null;
			this.EnrollmentDate = enrollmentDate;
			this.UniquePayment = uniquePayment;
			this.Student = student;
			this.TaughtCourse = taughtCourse;
		}
	}
}
