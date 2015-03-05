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
    public partial class frm_assignar_sport : Form
    {
        Logica_Deporte sport = new Logica_Deporte();
        Logica_Rutina rutina = new Logica_Rutina();
        Sport_Rutina relacion = new Sport_Rutina();
        Logica_Relacion_Sport_Rutina rela = new Logica_Relacion_Sport_Rutina();
        public frm_assignar_sport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_assignar_sport_Load(object sender, EventArgs e)
        {
            this.ChargeControls();
        }

        #region Cargar Controles
        void ChargeControls() 
        {
            //Cargo los deportes
            cmbSport.DataSource = sport.Charge_Sports();
            cmbSport.DisplayMember = "Deporte";

            //Cargo las rutinas en este 
            cmbRutine.DataSource = rutina.CargarRutinas();
            cmbRutine.DisplayMember = "Rutina";
            cmbSport.ValueMember = "Id";
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            relacion.Rutina_id = Convert.ToInt16(cmbRutine.SelectedIndex + 1);
            relacion.Sport_id = Convert.ToInt16(cmbSport.SelectedIndex+1);
            rela.create(relacion);

        }
    }
}
