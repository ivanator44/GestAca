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
    public partial class IntroducirDni : Form
    {
        private IGestAcaService service { get; set; }
        private TaughtCourse tc { get; set; }
        public IntroducirDni(IGestAcaService service, TaughtCourse tc)
        {
            InitializeComponent();
            this.service = service;
            this.tc = tc;
        }

        private void Aceptar_click(object sender, EventArgs e)
        {
            string dni = dnitextBox.Text;

            if (!string.IsNullOrEmpty(dni))
            {
                Student s = service.FindStudentByDni(dni);
                if (s == null) 
                {
                    var formDarAltaEstudiante = new AltaEstudiante(service, tc, dni);
                    formDarAltaEstudiante.ShowDialog();
                }
                else if (s.isAssignedToCourse(tc)) //esa persona ya esta en el curso tc
                {
                    MessageBox.Show("Estudiante ya matriculado en el curso seleccionado.", "Info");
                }
                else
                {
                    var formInfoEstudiante = new InfoEstudiante(service, tc, s,this);
                    formInfoEstudiante.ShowDialog();
                }
            }
        }
    }
}
