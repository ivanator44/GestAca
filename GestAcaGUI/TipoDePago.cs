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
    public partial class TipoDePago : Form
    {
        private IGestAcaService service { get; set; }
        private TaughtCourse tc { get; set; }
        private Student student { get; set; }
        private Form introducirDNI { get; set; }
        private Form infoStudent { get; set; }
        public TipoDePago(IGestAcaService service, TaughtCourse tc, Student s,Form dni, Form infoStudent)
        {
            InitializeComponent();
            this.service = service;
            this.tc = tc;
            this.student = s;
            this.introducirDNI = dni;
            this.infoStudent = infoStudent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var enrollment = new Enrollment(DateTime.Now, radioButton.Checked, student, tc);
            service.AddEnrollment(enrollment);
            MessageBox.Show("Estudiante matriculado.", "Info");
            this.Close();
            infoStudent.Close();
            introducirDNI.Close();
        }
    }
}
