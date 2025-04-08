using GestAca.Entities;
using GestAca.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GestAcaGUI
{
    public partial class AltaEstudiante : Form
    {
        private IGestAcaService service { get; set; }
        private TaughtCourse tc { get; set; }
        private string dni { get; set; }
        public AltaEstudiante(IGestAcaService service, TaughtCourse tc, string dni)
        {
            InitializeComponent();
            this.service = service;
            this.tc = tc;
            this.dni = dni;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = textBoxdireccion.Text;
            string nombre = textBoxnombre.Text;
            string zc = textBoxcp.Text;
            string iban = textBoxiban.Text;

            if (!string.IsNullOrEmpty(dir) && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(zc) && !string.IsNullOrEmpty(iban))
            {
                int zcInt = Int32.Parse(zc);
                Student student = new Student(dir, dni, nombre, zcInt, iban);

                service.AddStudent(student);
                MessageBox.Show("El estudiante se ha dado de alta correctamente.");
                this.Close();
            }
            
        }
    }
}
