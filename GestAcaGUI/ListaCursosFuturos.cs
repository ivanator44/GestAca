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
    public partial class ListaCursosFuturos : Form
    {
        private IGestAcaService service { get; set; }
        private IEnumerable<TaughtCourse> taughtCourses { get; set; }
        public ListaCursosFuturos(IGestAcaService service, IEnumerable<TaughtCourse> tc)
        {
            InitializeComponent();
            this.service = service;
            dataGridViewListaCursosFuturos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.taughtCourses = tc;
            LoadData();
        }

        public void LoadData()
        {
            bindingSourceListaCursosFuturos.DataSource = null;
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
            bindingSourceListaCursosFuturos.DataSource = bindingList;
        }

        private void inscribir_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaCursosFuturos.SelectedRows.Count == 1)
            {
                int id = Int32.Parse(dataGridViewListaCursosFuturos.CurrentRow.Cells[0].Value.ToString());
                TaughtCourse tc = service.FindTaughtCourseByID(id);
                var formDni = new IntroducirDni(service, tc);
                formDni.ShowDialog();
            }
        }
    }
}
