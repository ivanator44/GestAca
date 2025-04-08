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
    public partial class ListaCursos : Form
    {
        private IGestAcaService service { get; set; }
        private IEnumerable<TaughtCourse> taughtCourses { get; set; }
        public ListaCursos(IGestAcaService service, IEnumerable<TaughtCourse> tc)
        {
            InitializeComponent();
            this.service = service;
            dataGridViewListaCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.taughtCourses = tc;
            LoadData();
        }
        public void LoadData()
        {
            bindingSourceListaCursos.DataSource = null;
            BindingList<object> bindingList = new BindingList<object>();
            if (taughtCourses != null)
                foreach (TaughtCourse taughtCourse in taughtCourses)
                {
                    bindingList.Add(new
                    {
                        tc_Id = taughtCourse.Id,
                        tc_Nombre = taughtCourse.Course.Name,
                        tc_Descripcion = taughtCourse.Course.Description,
                    });
                }
            bindingSourceListaCursos.DataSource = bindingList;
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaCursos.SelectedRows.Count==1)
            {
                int id = Int32.Parse(dataGridViewListaCursos.CurrentRow.Cells[0].Value.ToString());
                TaughtCourse tc = service.FindTaughtCourseByID(id);
                var formInfoCurso = new InfoCurso(service,tc);
                formInfoCurso.ShowDialog();
            }
        }
    }
}
