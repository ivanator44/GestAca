using GestAca.Services;
using System.Windows.Forms;

namespace GestAcaGUI
{
    public partial class GestAcaAPP : Form
    {
        private IGestAcaService service { get; set; }
        public GestAcaAPP(IGestAcaService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void inicializarBD_click(object sender, EventArgs e)
        {
            try
            {
                service.DBInitialization();
                MessageBox.Show("La base de datos se ha inicializado correctamente");
            }
            catch (ServiceException ex)
            {
                MessageBox.Show("No se ha podido inicializar la base de datos");
                Console.WriteLine(ex.Message);
            }
        }

        private void botonSalir_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuCursos_click(object sender, EventArgs e)
        {
            var formListaCursos = new ListaCursos(service,service.FindAllCourses());
            formListaCursos.ShowDialog();
        }

        private void menuCursosFuturos_click(object sender, EventArgs e)
        {
            var formListaCursosFuturos = new ListaCursosFuturos(service, service.FindAllFutureCourses());
            formListaCursosFuturos.ShowDialog();
        }
    }
}
