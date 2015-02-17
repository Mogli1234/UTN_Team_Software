using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Software
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void crearDeporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Deporte de = new frm_Deporte();
            de.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frm_Login lo = new frm_Login();
            lo.Show();
            this.Hide();
        }

        private void verDeportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ViewSport view = new frm_ViewSport();
            view.ShowDialog();
        }

        private void crearRutinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Rutina oRut = new frm_Rutina();
            oRut.Show();
            this.Hide();
        }

        private void verRutinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_VerRutinas oVr = new frm_VerRutinas();
            oVr.Show();
            this.Hide();
        }

        private void rutinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EditarRutinas oEdRutinas = new frm_EditarRutinas();
            oEdRutinas.Show();
            this.Hide();
        }

    }
}
