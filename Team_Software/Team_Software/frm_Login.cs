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
    public partial class frm_Login : Form
    {
        Logica_User logica = new Logica_User();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (logica.Login(txtUsername.Text,txtPassword.Text))
            {
                MessageBox.Show("Bienvenido "+txtUsername.Text, "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_Menu ma = new Main_Menu();
                ma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create_User cr = new Create_User();
            cr.ShowDialog();
        }
    }
}
