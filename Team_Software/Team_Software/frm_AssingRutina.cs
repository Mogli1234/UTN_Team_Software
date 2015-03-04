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
    public partial class frm_AssingRutina : Form
    {
        Logica_Deporte sport = new Logica_Deporte();
        Logica_Rutina rutina = new Logica_Rutina();
        Logica_Paricipante participante = new Logica_Paricipante();
        Participante parti = new Participante();
        Sport_Rutine_Participante relacion = new Sport_Rutine_Participante();
        Logica_Tabla_Relacion relaci = new Logica_Tabla_Relacion();
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            parti.Nombre = txtNombre.Text;
            dtgParticipantes.DataSource = participante.fill(parti);
            dtgParticipantes.Columns[0].Visible = false;
            dtgParticipantes.Columns[1].HeaderText = "Nombre";
            dtgParticipantes.Columns[2].HeaderText = "Primer Apellido";
            dtgParticipantes.Columns[3].HeaderText = "Segundo Apellido";
            dtgParticipantes.Columns[4].HeaderText = "Edad";
            dtgParticipantes.Columns[5].HeaderText = "Fecha Ingreso";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            relacion.Sport_id = Convert.ToInt16(cmbSports.SelectedIndex+1);
            relacion.Rutina_id = Convert.ToInt16(cmbRutina.SelectedIndex+1);
            relaci.Create(relacion);
        }

        private void dtgParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            relacion.Participante_id = Convert.ToInt16(dtgParticipantes.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
