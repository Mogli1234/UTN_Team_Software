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
    public partial class frm_Rutina : Form
    {
        Rutinas oRutina = new Rutinas();
        Logica_Rutina oLRutina = new Logica_Rutina();
        public frm_Rutina()
        {
            InitializeComponent();
            txtRutina.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRutina.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar una rutina para continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                oRutina.Rutina = txtRutina.Text;
                oLRutina.Crear_Rutina(oRutina);

            }
            txtRutina.Clear();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
              this.Close();
        }
    }
}
