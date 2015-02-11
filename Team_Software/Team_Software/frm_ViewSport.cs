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
    public partial class frm_ViewSport : Form
    {
        Logica_Deporte logica = new Logica_Deporte();
        public frm_ViewSport()
        {
            InitializeComponent();
        }

        private void frm_ViewSport_Load(object sender, EventArgs e)
        {
            dtg_sport.DataSource = logica.Charge_Sports();
            dtg_sport.Columns[2].Visible =false;
            dtg_sport.Columns[1].HeaderText = "Descripción";
            dtg_sport.Columns[0].HeaderText = "Deporte";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
