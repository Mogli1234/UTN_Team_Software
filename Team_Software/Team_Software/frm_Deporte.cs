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
    public partial class frm_Deporte : Form
    {

        Sports sport = new Sports();
        Logica_Deporte logica = new Logica_Deporte();
        public frm_Deporte()
        {
            InitializeComponent();
            txtSport.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtSport.Text.Equals("")||txtDescription.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar espacios en blanco","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                sport.Deporte = txtSport.Text;
                sport.Description = txtDescription.Text;
                logica.Create_Sport(sport);
            }
            txtSport.Clear();
            txtDescription.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
