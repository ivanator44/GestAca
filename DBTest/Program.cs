using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestAca.Entities;
using GestAca.Persistence;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new GestAcaDbContext());

            CreateSampleDB(dal);
            PrintSampleDB(dal);
        }


        private void CreateSampleDB(IDAL dal)
        {
            dal.RemoveAllData();

            Console.WriteLine("CREANDO LOS DATOS Y ALMACENANDOLOS EN LA BD");
            Console.WriteLine("===========================================");

            Console.WriteLine("\n// CREACIÓN DE CURSOS");
            //public Course(string descr, string name)
            Course aCourse1 = new Course("Curso Introductorio Ingenieria Software", "Software Engineering");
            dal.Insert<Course>(aCourse1);
            dal.Commit();
            Course aCourse2 = new Course("Curso Introductorio de Estructuras de datos", "Data Structures");
            dal.Insert<Course>(aCourse2);
            dal.Commit();

            // Populate here the rest of the database
            // Add missing code here

            TaughtCourse aTaughtCourse1 = new TaughtCourse(new DateTime(1990, 01, 01), 1, 2, 90, new DateTime(1990, 02, 01), "Martes", 140, aCourse1);
            dal.Insert<TaughtCourse>(aTaughtCourse1);
            dal.Commit();

            TaughtCourse aTaughtCourse2 = new TaughtCourse(new DateTime(1991, 01, 01), 2, 2, 90, new DateTime(1991, 01, 01), "Lunes", 140, aCourse2);
            dal.Insert<TaughtCourse>(aTaughtCourse2);
            dal.Commit();

            Teacher aTeacher1 = new Teacher("Av del Cid", "P1", "Manuel Llavador", 46014, "ES0814656513574277716716");
            //aTeacher1.TaughtCourses.Add(aTaughtCourse1);
            dal.Insert<Teacher>(aTeacher1);
            Teacher aTeacher2 = new Teacher("Av del Cid", "P2", "Josep Silva", 46014, "ES0814656513574277716716");
            //aTeacher2.TaughtCourses.Add(aTaughtCourse2);
            dal.Insert<Teacher>(aTeacher2);

            Student student1 = new Student("Av del Cid", "S1", "Juan Mata", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student1);
            dal.Commit();
            Enrollment enrollment1 = new Enrollment(new DateTime(2001,01,01), true, student1, aTaughtCourse1);
            dal.Insert<Enrollment>(enrollment1);
            dal.Commit();

            Student student2 = new Student("Av del Cid", "S2", "Pedro Rodríguez", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student2);
            dal.Commit();
            Enrollment enrollment2 = new Enrollment(new DateTime(2002, 01, 01), true, student2, aTaughtCourse1);
            dal.Insert<Enrollment>(enrollment2);
            dal.Commit();

            Student student3 = new Student("Av del Cid", "S3", "Paco López", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student3);
            dal.Commit();
            Enrollment enrollment3 = new Enrollment(new DateTime(2003, 01, 01), true, student3, aTaughtCourse1);
            dal.Insert<Enrollment>(enrollment3);
            dal.Commit();

            Student student4 = new Student("Av del Cid", "S4", "David Rubio", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student4);
            dal.Commit();
            Enrollment enrollment4 = new Enrollment(new DateTime(2004, 01, 01), true, student4, aTaughtCourse1);
            dal.Insert<Enrollment>(enrollment4);
            dal.Commit();

            Student student5 = new Student("Av del Cid", "S5", "Marta Castillo", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student5);
            dal.Commit();
            Enrollment enrollment5 = new Enrollment(new DateTime(2005, 01, 01), true, student5, aTaughtCourse1);
            dal.Insert<Enrollment>(enrollment5);
            dal.Commit();

            Student student6 = new Student("Av del Cid", "S6", "Laura Gil", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student6);
            dal.Commit();
            Enrollment enrollment6 = new Enrollment(new DateTime(2006, 01, 01), true, student6, aTaughtCourse1);
            dal.Insert<Enrollment>(enrollment6);
            dal.Commit();

            Student student7 = new Student("Av del Cid", "S7", "Lucía Martínez", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student7);
            dal.Commit();
            Enrollment enrollment7 = new Enrollment(new DateTime(2007, 01, 01), true, student7, aTaughtCourse1);
            dal.Insert<Enrollment>(enrollment7);
            dal.Commit();

            Student student8 = new Student("Av del Cid", "S8", "Carlos Sanchis", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student8);
            dal.Commit();
            Enrollment enrollment8 = new Enrollment(new DateTime(2008, 01, 01), true, student8, aTaughtCourse1);
            dal.Insert<Enrollment>(enrollment8);
            dal.Commit();

            Student student9 = new Student("Av del Cid", "S9", "María García", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student9);
            dal.Commit();
            Enrollment enrollment9 = new Enrollment(new DateTime(2009, 01, 01), true, student9, aTaughtCourse1);
            dal.Insert<Enrollment>(enrollment9);
            dal.Commit();

            Student student10 = new Student("Av del Cid", "S10", "Rocío Rodrigo", 46014, "ES0814656513574277716716");
            dal.Insert<Student>(student10);
            dal.Commit();
            Absence a1 = new Absence(new DateTime(2015, 01, 10));
            dal.Insert<Absence>(a1);
            dal.Commit();
            Absence a2 = new Absence(new DateTime(2015, 02, 10));
            dal.Insert<Absence>(a2);
            dal.Commit();
            Enrollment enrollment10 = new Enrollment(new DateTime(2010, 01, 01), true, student10, aTaughtCourse1);
            enrollment10.Absences.Add(a1);
            enrollment10.Absences.Add(a2);
            dal.Insert<Enrollment>(enrollment10);
            dal.Commit();

            Classroom c1 = new Classroom(30, "Clase de Ingenieria Software");
            c1.TaughtCourses.Add(aTaughtCourse1);
            dal.Insert<Classroom>(c1);
            dal.Commit();

            Classroom c2 = new Classroom(30, "Clase de Estructuras de datos");
            c2.TaughtCourses.Add(aTaughtCourse2);
            dal.Insert<Classroom>(c2);
            dal.Commit();

        }


        private void PrintSampleDB(IDAL dal)
        {
            Console.WriteLine("\n\nMOSTRANDO LOS DATOS DE LA BD");
            Console.WriteLine("============================\n");

            Console.WriteLine("\nCursos creados:");
            foreach (Course c in dal.GetAll<Course>())
                Console.WriteLine("   Name: " + c.Name + " Description: " + c.Description);

            // Show the rest of the database
            Console.WriteLine("\nProfesores creados:");
            foreach (Teacher t in dal.GetAll<Teacher>())
                Console.WriteLine("   ID: " + t.Id + " Name: " + t.Name);

            Console.WriteLine("\nImparticiones de cursos creados:");
            foreach (Course c in dal.GetAll<Course>())
            {
                Console.WriteLine("   Name: " + c.Name + " Description: " + c.Description);
                foreach (TaughtCourse tc in c.TaughtCourses)
                    Console.WriteLine("      ID: " + tc.Id + " START: " + tc.StartDateTime + " END: " + tc.EndDate);
            }

            Console.WriteLine("\nInscripciones por curso a impartir:");
            foreach (Course c in dal.GetAll<Course>())
            {
                Console.WriteLine("   Name: " + c.Name + " Description: " + c.Description);
                foreach (TaughtCourse tc in c.TaughtCourses)
                {
                    Console.WriteLine("      ID: " + tc.Id + " START: " + tc.StartDateTime + " END: " + tc.EndDate);
                    foreach (Enrollment en in tc.Enrollments)
                        Console.WriteLine("      ---> Student: " + en.Student.Name + " Enrollment Date: " + en.EnrollmentDate);
                }

            }

            Console.WriteLine("\nAulas creadas y sus asignaciones");
            foreach (Classroom o in dal.GetAll<Classroom>())
            {
                Console.WriteLine("   Name: " + o.Name + " Capacity: " + o.MaxCapacity);
                foreach (TaughtCourse tc in o.TaughtCourses)
                    Console.WriteLine("      CourseID: " + tc.Id + " START: " + tc.StartDateTime + " END: " + tc.EndDate + " People: " + tc.Enrollments.Count);
            }

            Console.WriteLine("\nFaltas de asistencia por alumno");
            foreach (Student s in dal.GetAll<Student>())
            {
                Console.WriteLine("   Student Name: " + s.Name);
                foreach (Enrollment en in s.Enrollments)
                {
                    Console.WriteLine("      Enrollment in: " + en.TaughtCourse.Id + " Course name: " + en.TaughtCourse.Course.Name + " Absences: " + en.Absences.Count);
                    foreach (Absence ab in en.Absences)
                        Console.WriteLine("         Date: " + ab.Date);
                }

            }
        }

    }

}
