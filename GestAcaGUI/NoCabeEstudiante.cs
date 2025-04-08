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
    public partial class NoCabeEstudiante : Form
    {
        private IGestAcaService service { get; set; }
        private Form introducirDNI { get; set; }
        private Form infoStudent { get; set; }
        public NoCabeEstudiante(IGestAcaService service, Form introducirDNI, Form info)
        {
            InitializeComponent();
            this.service = service;
            this.introducirDNI = introducirDNI;
            this.infoStudent = info;
        }

        private void aceptar_click(object sender, EventArgs e)
        {
            this.Close();
            this.infoStudent.Close();
            this.introducirDNI.Close();
        }
    }
}
