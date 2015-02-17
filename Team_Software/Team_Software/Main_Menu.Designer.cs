namespace Team_Software
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeporte = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDeporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDeportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminiarDeporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParticipante = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarParticipanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarParticipanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verParticipantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRutina = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRutinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRutinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeporte,
            this.btnParticipante,
            this.btnRutina,
            this.toolStripSeparator2,
            this.btnSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // btnDeporte
            // 
            this.btnDeporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDeporteToolStripMenuItem,
            this.verDeportesToolStripMenuItem,
            this.eliminiarDeporteToolStripMenuItem});
            this.btnDeporte.Name = "btnDeporte";
            this.btnDeporte.Size = new System.Drawing.Size(143, 22);
            this.btnDeporte.Text = "Deporte";
            // 
            // crearDeporteToolStripMenuItem
            // 
            this.crearDeporteToolStripMenuItem.Name = "crearDeporteToolStripMenuItem";
            this.crearDeporteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.crearDeporteToolStripMenuItem.Text = "Crear Deporte";
            this.crearDeporteToolStripMenuItem.Click += new System.EventHandler(this.crearDeporteToolStripMenuItem_Click);
            // 
            // verDeportesToolStripMenuItem
            // 
            this.verDeportesToolStripMenuItem.Name = "verDeportesToolStripMenuItem";
            this.verDeportesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.verDeportesToolStripMenuItem.Text = "Ver Deportes";
            this.verDeportesToolStripMenuItem.Click += new System.EventHandler(this.verDeportesToolStripMenuItem_Click);
            // 
            // eliminiarDeporteToolStripMenuItem
            // 
            this.eliminiarDeporteToolStripMenuItem.Name = "eliminiarDeporteToolStripMenuItem";
            this.eliminiarDeporteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eliminiarDeporteToolStripMenuItem.Text = "Eliminiar Deporte";
            // 
            // btnParticipante
            // 
            this.btnParticipante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarParticipanteToolStripMenuItem,
            this.eliminarParticipanteToolStripMenuItem,
            this.verParticipantesToolStripMenuItem});
            this.btnParticipante.Name = "btnParticipante";
            this.btnParticipante.Size = new System.Drawing.Size(143, 22);
            this.btnParticipante.Text = "Participantes";
            // 
            // ingresarParticipanteToolStripMenuItem
            // 
            this.ingresarParticipanteToolStripMenuItem.Name = "ingresarParticipanteToolStripMenuItem";
            this.ingresarParticipanteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ingresarParticipanteToolStripMenuItem.Text = "Ingresar Participante";
            // 
            // eliminarParticipanteToolStripMenuItem
            // 
            this.eliminarParticipanteToolStripMenuItem.Name = "eliminarParticipanteToolStripMenuItem";
            this.eliminarParticipanteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.eliminarParticipanteToolStripMenuItem.Text = "Eliminar Participante";
            // 
            // verParticipantesToolStripMenuItem
            // 
            this.verParticipantesToolStripMenuItem.Name = "verParticipantesToolStripMenuItem";
            this.verParticipantesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.verParticipantesToolStripMenuItem.Text = "Ver Participantes";
            // 
            // btnRutina
            // 
            this.btnRutina.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRutinaToolStripMenuItem,
            this.verRutinasToolStripMenuItem});
            this.btnRutina.Name = "btnRutina";
            this.btnRutina.Size = new System.Drawing.Size(143, 22);
            this.btnRutina.Text = "Rutina";
            // 
            // crearRutinaToolStripMenuItem
            // 
            this.crearRutinaToolStripMenuItem.Name = "crearRutinaToolStripMenuItem";
            this.crearRutinaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.crearRutinaToolStripMenuItem.Text = "Crear Rutina";
            this.crearRutinaToolStripMenuItem.Click += new System.EventHandler(this.crearRutinaToolStripMenuItem_Click);
            // 
            // verRutinasToolStripMenuItem
            // 
            this.verRutinasToolStripMenuItem.Name = "verRutinasToolStripMenuItem";
            this.verRutinasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.verRutinasToolStripMenuItem.Text = "Ver Rutinas";
            this.verRutinasToolStripMenuItem.Click += new System.EventHandler(this.verRutinasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 22);
            this.btnSalir.Text = "&Cerrar Sesion";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deporteToolStripMenuItem,
            this.rutinaToolStripMenuItem,
            this.participanteToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // deporteToolStripMenuItem
            // 
            this.deporteToolStripMenuItem.Name = "deporteToolStripMenuItem";
            this.deporteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deporteToolStripMenuItem.Text = "Deporte";
            // 
            // rutinaToolStripMenuItem
            // 
            this.rutinaToolStripMenuItem.Name = "rutinaToolStripMenuItem";
            this.rutinaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rutinaToolStripMenuItem.Text = "Rutina";
            this.rutinaToolStripMenuItem.Click += new System.EventHandler(this.rutinaToolStripMenuItem_Click);
            // 
            // participanteToolStripMenuItem
            // 
            this.participanteToolStripMenuItem.Name = "participanteToolStripMenuItem";
            this.participanteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.participanteToolStripMenuItem.Text = "Participante";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.acercadeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(132, 6);
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 435);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeporte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearDeporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDeportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminiarDeporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnParticipante;
        private System.Windows.Forms.ToolStripMenuItem btnRutina;
        private System.Windows.Forms.ToolStripMenuItem deporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarParticipanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarParticipanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verParticipantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRutinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRutinasToolStripMenuItem;

    }
}