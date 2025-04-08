using GestAca.Entities;
using GestAca.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestAcaGUI
{
    public partial class InfoCurso : Form
    {
        private IGestAcaService service { get; set; }
        private TaughtCourse taughtCourse { get; set; }
        public InfoCurso(IGestAcaService service, TaughtCourse tc)
        {
            InitializeComponent();
            this.service = service;
            this.taughtCourse = tc;
            LoadData();
        }

        public void LoadData()
        {
            label11.Text = taughtCourse.Id + "";
            label12.Text = taughtCourse.Course.Name;
            label13.Text = taughtCourse.Course.Description;
            label14.Text = taughtCourse.Quotas + "";
            label15.Text = taughtCourse.SessionDuration + "";
            label16.Text = taughtCourse.StartDateTime.ToString();
            label17.Text = taughtCourse.EndDate.ToString();
            label18.Text = taughtCourse.TotalPrice + "";
            if (taughtCourse.Classroom != null)
            {
                label19.Text = taughtCourse.Classroom.Name;
            }

            string s = "";
            foreach (Teacher t in taughtCourse.Teachers)
            {
                s = s + " " + t.Name;
            }
            label20.Text = s;


        }

        private void profesoresCompatibles_click(object sender, EventArgs e)
        {
            var formListaProfesores = new ListaProfesores(service, taughtCourse, service.FindAvailableTeachersForCourse(taughtCourse));
            formListaProfesores.ShowDialog();

        }

        private void aulasCompatibles_click(object sender, EventArgs e)
        {
            var formListaAulas = new ListaAulas(service, taughtCourse, service.FindAvailableClassroomsForCourse(taughtCourse));
            formListaAulas.ShowDialog();
        }

        private void listaAlumnos_click(object sender, EventArgs e)
        {
            var formListaAlumnos = new ListaAlumnos(service,taughtCourse.Enrollments);
            formListaAlumnos.ShowDialog();
        }
    }
}
