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
    public partial class frm_AssingRutina : Form
    {
        Logica_Deporte sport = new Logica_Deporte();
        Logica_Rutina rutina = new Logica_Rutina();
        Logica_Paricipante participante = new Logica_Paricipante();
        public frm_AssingRutina()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AssingRutina_Load(object sender, EventArgs e)
        {
            this.charge_Objects();
        }


        #region Cargar Objeto
        public void charge_Objects() 
        {
            //Cargar Combox
            cmbSports.DataSource = sport.Charge_Sports();
            cmbSports.DisplayMember = "Deporte";
            cmbSports.ValueMember = "Id";

            cmbRutina.DataSource = rutina.CargarRutinas();
            cmbRutina.DisplayMember = "Rutina";
            cmbRutina.ValueMember = "Id";
            //carga Dartagrid
            dtgParticipantes.DataSource = participante.cargar();
            dtgParticipantes.Columns[0].Visible = false;
            dtgParticipantes.Columns[1].HeaderText = "Nombre";
            dtgParticipantes.Columns[2].HeaderText = "Primer Apellido";
            dtgParticipantes.Columns[3].HeaderText = "Segundo Apellido";
            dtgParticipantes.Columns[4].HeaderText = "Edad";
            dtgParticipantes.Columns[5].HeaderText = "Fecha Ingreso";
        }
        #endregion
    }
}
