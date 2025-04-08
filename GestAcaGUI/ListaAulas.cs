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
    public partial class ListaAulas : Form
    {
        private IGestAcaService service { get; set; }
        private TaughtCourse taughtCourse { get; set; }
        private IEnumerable<Classroom> classrooms { get; set; }
        public ListaAulas(IGestAcaService service, TaughtCourse tc, IEnumerable<Classroom> c)
        {
            InitializeComponent();
            this.service = service;
            this.taughtCourse = tc;
            this.classrooms = c;
            dataGridViewListaAulas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadData();
        }
        //COMPLETAR
        public void LoadData() {
            BindingList<object> bindingList = new BindingList<object>();
            if (classrooms != null)
                foreach (Classroom classroom in classrooms)
                {
                    bindingList.Add(new
                    {
                        c_Max_Cap = classroom.MaxCapacity,
                        c_Nombre = classroom.Name,
                    });
                }
            
            bindingSourceListaAulas.DataSource = bindingList;
        }
        //COMPLETAR
        private void asignar_click(object sender, EventArgs e)
        {
            if (dataGridViewListaAulas.SelectedRows.Count == 1)
            {
                string name = dataGridViewListaAulas.CurrentRow.Cells[1].Value.ToString();
                Classroom classroom = service.FindClassroomByName(name);
                if (this.taughtCourse.Classroom != null)
                {
                    var confirmarAula = new ConfirmarAula(service,this.taughtCourse,classroom);
                    confirmarAula.ShowDialog();
                }
                else {
                    taughtCourse.addClassroom(classroom);
                    service.Commit();
                    MessageBox.Show("Se ha asignado el aula seleccionada al curso");
                }
                this.Close();
            }
        }
    }
}
