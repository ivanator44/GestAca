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
    public partial class ListaAlumnos : Form
    {
        private IGestAcaService service { get; set; }
        private IEnumerable<Enrollment> enrollments { get; set; }
        public ListaAlumnos(IGestAcaService service, IEnumerable<Enrollment> e)
        {
            InitializeComponent();
            this.service = service;
            this.enrollments = e;
            LoadData();
        }
        //COMPLETAR
        public void LoadData()
        {
            //el binding source aquí se llama BindingSourceListaAlumnos
            bindingSourceListaAlumnos.DataSource = null;
            BindingList<object> bindingList = new BindingList<object>();
            string tipoPago = "";
            if (enrollments != null)
                foreach (Enrollment enrollment in enrollments)
                {
                    if (enrollment.UniquePayment)
                    {
                        tipoPago = "Completo";
                    }
                    else
                    {
                        tipoPago = "Cuotas mensuales";
                    }
                    bindingList.Add(new
                    {
                        s_Nombre = enrollment.Student.Name,
                        s_Pago = tipoPago
                    });
                }
            bindingSourceListaAlumnos.DataSource = bindingList;
        }
    }
}
