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
    public partial class ConfirmarAula : Form
    {
        private IGestAcaService service { get; set; }
        private TaughtCourse taughtCourse { get; set; }

        private Classroom classroom { get; set; }
        public ConfirmarAula(IGestAcaService s, TaughtCourse t, Classroom c)
        {
            InitializeComponent();
            this.service = s;
            this.taughtCourse = t;
            this.classroom = c;
        }

        private void cambiarAula_click(object sender, EventArgs e)
        {
            this.taughtCourse.addClassroom(this.classroom);
            service.Commit();
            MessageBox.Show("Se ha asignado el aula seleccionada al curso");
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
