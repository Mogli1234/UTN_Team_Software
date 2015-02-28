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
    public partial class frm_VerRutinas : Form
    {
        Capa_Logica.Logica_Rutina oLogRutina = new Capa_Logica.Logica_Rutina();

        public frm_VerRutinas()
        {
            InitializeComponent();
        }        

        private void frm_VerRutinas_Load(object sender, EventArgs e)
        {
            dtgRutinas.DataSource = oLogRutina.CargarRutinas();
            dtgRutinas.Columns[1].HeaderText = "Detalle Rutina";
            dtgRutinas.Columns[0].HeaderText = "Id Rutina";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
