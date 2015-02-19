using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Capa_Logica;

namespace Team_Software
{
    public partial class Create_User : Form
    {
        Users user = new Users();
        Logica_User logica = new Logica_User();
        
        public Create_User()
        {
            InitializeComponent();
            this.Limpiar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            user.Username = txtUsername.Text;
            user.Email = txtEmail.Text;
            if (txtPass.Text.Equals(txtConfirmPass.Text))
            {
                user.Password = txtPass.Text;
                logica.Create_User(user);
            }
            else
            {
                MessageBox.Show("La constraseñas no coinciden","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.Limpiar();

        }

        public void Limpiar() 
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPass.Clear();
            txtConfirmPass.Clear();
            txtUsername.Focus();
        }
    }
}
