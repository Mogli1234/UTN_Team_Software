using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using Entidades;

namespace Team_Software
{
    public partial class frm_EditarRutinas : Form
    {
        Logica_Rutina oLogRutina = new Logica_Rutina();
        Rutinas oRut = new Rutinas();
        public frm_EditarRutinas()
        {
            InitializeComponent();
        }

        private void EditarRutinas_Load(object sender, EventArgs e)
        {
            this.CargarRutina();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oRut.Id = Convert.ToInt32(dtgEditRutinas.SelectedCells[0].Value.ToString());
            oRut.Rutina = txtRutina.Text;
            oLogRutina.Actualiza_Rutina(oRut);
            this.CargarRutina();
        }

        private void dtgEditRutinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRutina.Text = dtgEditRutinas.CurrentRow.Cells[1].Value.ToString();
        }

     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oRut.Id = Convert.ToInt32(dtgEditRutinas.SelectedCells[0].Value.ToString());
            oRut.Rutina = Convert.ToString(dtgEditRutinas.SelectedCells[1].Value.ToString());
            oLogRutina.Delete_Rutina(oRut);
            
            this.CargarRutina();
        }

        public void CargarRutina()
        {
            dtgEditRutinas.DataSource = oLogRutina.CargarRutinas();
            dtgEditRutinas.Columns[0].Visible = false;
            dtgEditRutinas.Columns[1].HeaderText = "Detalle de Rutina";
        }
    }
}
