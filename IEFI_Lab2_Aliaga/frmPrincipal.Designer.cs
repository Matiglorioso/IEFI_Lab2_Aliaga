namespace IEFI_Lab2_Aliaga
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarNuevoSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevopaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienv = new System.Windows.Forms.Label();
            this.lblSelecc = new System.Windows.Forms.Label();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoSocioToolStripMenuItem,
            this.registrarNuevopaisToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarNuevoSocioToolStripMenuItem
            // 
            this.registrarNuevoSocioToolStripMenuItem.Name = "registrarNuevoSocioToolStripMenuItem";
            this.registrarNuevoSocioToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.registrarNuevoSocioToolStripMenuItem.Text = "&Registrar nuevo socio";
            this.registrarNuevoSocioToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoSocioToolStripMenuItem_Click);
            // 
            // registrarNuevopaisToolStripMenuItem
            // 
            this.registrarNuevopaisToolStripMenuItem.Name = "registrarNuevopaisToolStripMenuItem";
            this.registrarNuevopaisToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.registrarNuevopaisToolStripMenuItem.Text = "Registrar nuevo &pais";
            this.registrarNuevopaisToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevopaisToolStripMenuItem_Click);
            // 
            // lblBienv
            // 
            this.lblBienv.AutoSize = true;
            this.lblBienv.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienv.Location = new System.Drawing.Point(119, 81);
            this.lblBienv.Name = "lblBienv";
            this.lblBienv.Size = new System.Drawing.Size(332, 37);
            this.lblBienv.TabIndex = 1;
            this.lblBienv.Text = "Sea bienvenido a \"El Club\"";
            // 
            // lblSelecc
            // 
            this.lblSelecc.AutoSize = true;
            this.lblSelecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecc.Location = new System.Drawing.Point(154, 155);
            this.lblSelecc.Name = "lblSelecc";
            this.lblSelecc.Size = new System.Drawing.Size(252, 20);
            this.lblSelecc.TabIndex = 2;
            this.lblSelecc.Text = "Seleccione una opción en la barra.";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 262);
            this.Controls.Add(this.lblSelecc);
            this.Controls.Add(this.lblBienv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "¡Bienvenidxs!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevopaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblBienv;
        private System.Windows.Forms.Label lblSelecc;
    }
}