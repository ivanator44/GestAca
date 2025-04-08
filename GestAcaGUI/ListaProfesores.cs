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
    public partial class ListaProfesores : Form
    {
        private IGestAcaService service { get; set; }
        private TaughtCourse taughtCourse { get; set; }
        private IEnumerable<Teacher> teachers { get; set; }
        public ListaProfesores(IGestAcaService service, TaughtCourse tc, IEnumerable<Teacher> t)
        {
            InitializeComponent();
            this.service = service;
            this.taughtCourse = tc;
            this.teachers = t;
            dataGridViewListaProfesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadData();
        }

        public void LoadData()
        {
            BindingList<object> bindingList = new BindingList<object>();
            if (teachers != null)
            {
                foreach (Teacher t in teachers)
                    bindingList.Add(new
                    {
                        t_Id = t.Id,
                        t_Nombre = t.Name,
                        t_Direccion = t.Address,
                        t_CP = t.ZipCode,
                        t_SSN = t.Ssn
                    });
                bindingSourceListaProfesores.DataSource = bindingList;
            }
        }

        private void asignar_click(object sender, EventArgs e)
        {
            if (dataGridViewListaProfesores.SelectedRows.Count == 1)
            {
                string id = dataGridViewListaProfesores.CurrentRow.Cells[0].Value.ToString();
                Teacher teacher = service.FindTeacherByDni(id);
                taughtCourse.addTeacher(teacher);
                service.Commit();
                MessageBox.Show("Se ha asignado el profesor seleccionado al curso");
                this.Close();
            }
        }
    }
}
