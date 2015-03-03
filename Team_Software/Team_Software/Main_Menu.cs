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
            oRut.ShowDialog();
        }

        private void verRutinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_VerRutinas oVr = new frm_VerRutinas();
            oVr.ShowDialog();
        }

        private void rutinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EditarRutinas oEdRutinas = new frm_EditarRutinas();
            oEdRutinas.ShowDialog();
        }

        private void dtnEditSport_Click(object sender, EventArgs e)
        {
            Edit_Sport edi = new Edit_Sport();
            edi.ShowDialog();
        }


        private void btnAsignar_Click(object sender, EventArgs e)
        {
            frm_AssingRutina assign = new frm_AssingRutina();
            assign.ShowDialog();
        }

        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            frm_AssingRutina assing = new frm_AssingRutina();
            assing.ShowDialog();
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            frm_Participante parti = new frm_Participante();
            parti.ShowDialog();
        }


    }
}
