using GestAca.Entities;
using GestAca.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestAcaGUI
{
    public partial class InfoEstudiante : Form
    {
        private IGestAcaService service { get; set; }
        private TaughtCourse tc { get; set; }
        private Student student { get; set; }
        private Form introducirDNI { get; set; }
        public InfoEstudiante(IGestAcaService service, TaughtCourse tc, Student s, Form dni)
        {
            InitializeComponent();
            this.service = service;
            this.tc = tc;
            this.student = s;
            this.introducirDNI = dni;
            LoadData();
        }

        public void LoadData()
        {
            label7.Text = student.Address;
            label8.Text = student.Name;
            label9.Text = student.Id;
            label10.Text = student.ZipCode + "";
            label11.Text = student.IBAN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tc.classroomIsFull()) { 

                var formNoCabe = new NoCabeEstudiante(service,introducirDNI,this);
                formNoCabe.ShowDialog();

            } else if (student.isAssignedToCourse(tc)) {

                MessageBox.Show("Estudiante ya matriculado en el curso seleccionado.", "Info");

            } else {

                var formPago = new TipoDePago(service, tc, student,this.introducirDNI,this);
                formPago.ShowDialog();

            }
        }
    }
}
