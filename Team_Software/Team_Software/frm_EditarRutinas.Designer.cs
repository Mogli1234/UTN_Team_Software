namespace Team_Software
{
    partial class frm_EditarRutinas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgEditRutinas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblRutina = new DevComponents.DotNetBar.LabelX();
            this.txtRutina = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditRutinas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEditRutinas
            // 
            this.dtgEditRutinas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgEditRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEditRutinas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEditRutinas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgEditRutinas.Location = new System.Drawing.Point(371, 33);
            this.dtgEditRutinas.Name = "dtgEditRutinas";
            this.dtgEditRutinas.Size = new System.Drawing.Size(457, 162);
            this.dtgEditRutinas.TabIndex = 0;
            // 
            // lblRutina
            // 
            // 
            // 
            // 
            this.lblRutina.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRutina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRutina.Location = new System.Drawing.Point(12, 22);
            this.lblRutina.Name = "lblRutina";
            this.lblRutina.Size = new System.Drawing.Size(107, 27);
            this.lblRutina.TabIndex = 1;
            this.lblRutina.Text = "Detalle Rutina";
            // 
            // txtRutina
            // 
            // 
            // 
            // 
            this.txtRutina.Border.Class = "TextBoxBorder";
            this.txtRutina.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRutina.Location = new System.Drawing.Point(12, 55);
            this.txtRutina.Multiline = true;
            this.txtRutina.Name = "txtRutina";
            this.txtRutina.Size = new System.Drawing.Size(326, 116);
            this.txtRutina.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Location = new System.Drawing.Point(12, 254);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            // 
            // EditarRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 289);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtRutina);
            this.Controls.Add(this.lblRutina);
            this.Controls.Add(this.dtgEditRutinas);
            this.Name = "EditarRutinas";
            this.Text = "EditarRutinas";
            this.Load += new System.EventHandler(this.EditarRutinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditRutinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgEditRutinas;
        private DevComponents.DotNetBar.LabelX lblRutina;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRutina;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
    }
}