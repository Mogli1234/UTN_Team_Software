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
    public partial class frm_Participante : Form
    {
        Logica_Paricipante logica = new Logica_Paricipante();
        Participante parti = new Participante();
        public frm_Participante()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Participante_Load(object sender, EventArgs e)
        {
            dt_fecha.Enabled = false;
            dt_fecha.Value = DateTime.Today;
        }

        private void btn_GuardarParticipante_Click(object sender, EventArgs e)
        {
            parti.Nombre = txt_Nombre.Text;
            parti.Primer_apellido = txt_PrimerApellido.Text;
            parti.Segundo_apellido = txt_SegundoApellido.Text;
            parti.Edad = Convert.ToInt16(intEdad.Value);
            parti.Fecha_ingreso = dt_fecha.Text;
            logica.Create(parti);
            this.Limpiar_cajas();
        }

        #region Limpiar
        public void Limpiar_cajas() 
        {
            txt_Nombre.Clear();
            intEdad.Value = 1;
            txt_PrimerApellido.Clear();
            txt_SegundoApellido.Clear();
            txt_Nombre.Focus();
        }
        #endregion
    }
}
