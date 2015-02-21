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
    public partial class Edit_Sport : Form
    {
        Logica_Deporte logica = new Logica_Deporte();
        Sports sport = new Sports();
        public Edit_Sport()
        {
            InitializeComponent();
        }

        private void Edit_Sport_Load(object sender, EventArgs e)
        {
            this.LimpiarTextFlieds();
            this.cargarTable();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgSports_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSport.Text = dtgSports.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescription.Text = dtgSports.Rows[e.RowIndex].Cells[1].Value.ToString();
            sport.Id = Convert.ToInt16(dtgSports.Rows[e.RowIndex].Cells[2].Value);
            txtSport.Enabled = true;
            txtDescription.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sport.Deporte = txtSport.Text;
            sport.Description = txtDescription.Text;
            logica.Update_Sport(sport);
            this.LimpiarTextFlieds();
            this.cargarTable();

        }
        private void cargarTable()
        {
            dtgSports.DataSource = logica.Charge_Sports();
            dtgSports.Columns[2].Visible = false;
            dtgSports.Columns[1].HeaderText = "Descripción";
            dtgSports.Columns[0].HeaderText = "Deporte";
        }
        private void LimpiarTextFlieds() 
        {
            txtSport.Enabled = false;
            txtDescription.Enabled = false;
            txtSport.Clear();
            txtDescription.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sport.Id = Convert.ToInt16(dtgSports.CurrentRow.Cells[2].Value);
            logica.Delete_Sport(sport);
            this.cargarTable();
        }

    }
}
