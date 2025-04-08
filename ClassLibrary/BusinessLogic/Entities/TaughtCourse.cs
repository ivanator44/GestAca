using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAca.Services;

namespace GestAca.Entities
{
    public partial class TaughtCourse
    {
        // constructores
        public TaughtCourse()
        {
            this.Teachers = new List<Teacher>();
            this.Enrollments = new List<Enrollment>();
        }

        public TaughtCourse(DateTime endDate, int id, int quotas, int ssessionDuration, DateTime startDateTime, string teachingDay, int totalPrice, Course course)
        : this()
        {
            this.EndDate = endDate;
            this.Id = id;
            this.Quotas = quotas;
            this.SessionDuration = ssessionDuration;
            this.StartDateTime = startDateTime;
            this.TeachingDay = teachingDay;
            this.TotalPrice = totalPrice;
            this.Course = course;
        }

        public bool coursesAreSuitable(TaughtCourse tc)
        {
            //Si endsBefore = true significa que un curso ha finalizado antes de que empiece el otro, por lo que no hay posibilidad de solapamiento
            bool endsBefore = (this.EndDate <= tc.StartDateTime) || (tc.EndDate <= this.StartDateTime);

            //Si sameTeachingDay = true significa que ambos cursos se enseñan el mismo día de la semana
            bool sameTeachingDay = this.TeachingDay.Equals(tc.TeachingDay);

            //cuándo se empieza a impartir la leccion de cada clase de this (en segundos)
            int startThis = this.StartDateTime.Hour * 3600 + this.StartDateTime.Minute * 60 + this.StartDateTime.Second;
            //cuándo se acaba de impartir la leccion de cada clase de this (en segundos)
            int endThis = startThis + this.SessionDuration * 60;

            //lo mismo que se ha calculado para this
            int startTc = tc.StartDateTime.Hour * 3600 + tc.StartDateTime.Minute * 60 + tc.StartDateTime.Second;
            int endTc = startTc + tc.SessionDuration * 60;

            //Si differentTimes = true significa que la leccion de la clase de un curso acaba antes
            //o a la misma hora a la que empieza la del otro
            bool differentTimes = (endThis <= startTc) || (endTc <= startThis);

            if (!endsBefore && sameTeachingDay && !differentTimes) { return false; }
            else { return true; }
        }
        public void addTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }
        public void addClassroom(Classroom classroom)
        {
            this.Classroom = classroom;
        }

        public bool classroomIsFull()
        {
            if (this.Classroom != null && this.Classroom.MaxCapacity == this.Enrollments.Count)
            {
                return true;
            }
            return false;
        }
    }
}
