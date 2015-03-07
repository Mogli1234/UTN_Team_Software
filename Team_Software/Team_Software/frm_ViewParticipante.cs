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
    public partial class frm_ViewParticipante: Form
    {
        Logica_Paricipante logicaPart = new Logica_Paricipante();
        public frm_ViewParticipante()
        {
            InitializeComponent();
        }

        private void frm_ViewSport_Load(object sender, EventArgs e)
        {
            dtg_Participantes.DataSource = logicaPart.Cargar();
            dtg_Participantes.Columns[5].Visible =false;
            dtg_Participantes.Columns[4].HeaderText = "Nombre";
            dtg_Participantes.Columns[3].HeaderText = "Primer Apellido";
            dtg_Participantes.Columns[2].HeaderText = "Segundo Apellido";
            dtg_Participantes.Columns[1].HeaderText = "Edad";
            dtg_Participantes.Columns[0].HeaderText = "Fecha de Ingreso";
        }

        private void btnAceptarSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
