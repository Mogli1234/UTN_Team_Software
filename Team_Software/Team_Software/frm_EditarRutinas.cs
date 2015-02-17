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

namespace Team_Software
{
    public partial class frm_EditarRutinas : Form
    {
        Logica_Rutina oLogRutina = new Logica_Rutina();
        public frm_EditarRutinas()
        {
            InitializeComponent();
        }

        private void EditarRutinas_Load(object sender, EventArgs e)
        {
            dtgEditRutinas.DataSource = oLogRutina.CargarRutinas();
            dtgEditRutinas.Columns[2].HeaderText = "Del";
            dtgEditRutinas.Columns[1].HeaderText = "Detalle Rutina";
            dtgEditRutinas.Columns[0].HeaderText = "Id Rutina";
        }
    }
}
