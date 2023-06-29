namespace IEFI_Lab2_Aliaga
{
    partial class frmAgregarPais
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
            this.lblAddPais = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAddPais = new System.Windows.Forms.TextBox();
            this.mrcAddPais = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mrcAddPais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddPais
            // 
            this.lblAddPais.AutoSize = true;
            this.lblAddPais.Location = new System.Drawing.Point(79, 44);
            this.lblAddPais.Name = "lblAddPais";
            this.lblAddPais.Size = new System.Drawing.Size(66, 13);
            this.lblAddPais.TabIndex = 0;
            this.lblAddPais.Text = "Nuevo país:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(212, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtAddPais
            // 
            this.txtAddPais.Location = new System.Drawing.Point(63, 66);
            this.txtAddPais.Name = "txtAddPais";
            this.txtAddPais.Size = new System.Drawing.Size(100, 20);
            this.txtAddPais.TabIndex = 2;
            // 
            // mrcAddPais
            // 
            this.mrcAddPais.Controls.Add(this.btnVolver);
            this.mrcAddPais.Controls.Add(this.lblAddPais);
            this.mrcAddPais.Controls.Add(this.txtAddPais);
            this.mrcAddPais.Controls.Add(this.btnAgregar);
            this.mrcAddPais.Location = new System.Drawing.Point(12, 12);
            this.mrcAddPais.Name = "mrcAddPais";
            this.mrcAddPais.Size = new System.Drawing.Size(302, 123);
            this.mrcAddPais.TabIndex = 3;
            this.mrcAddPais.TabStop = false;
            this.mrcAddPais.Text = "¡Agregá un país!";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(212, 83);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAgregarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 154);
            this.Controls.Add(this.mrcAddPais);
            this.Name = "frmAgregarPais";
            this.Text = "¡Agregue un nuevo país!";
            this.mrcAddPais.ResumeLayout(false);
            this.mrcAddPais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddPais;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAddPais;
        private System.Windows.Forms.GroupBox mrcAddPais;
        private System.Windows.Forms.Button btnVolver;
    }
}